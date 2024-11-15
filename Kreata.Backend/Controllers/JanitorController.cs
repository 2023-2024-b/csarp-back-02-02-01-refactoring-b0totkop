using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Kreata.Backend.Dtos;
using Kreata.Backend.Extensions;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JanitorController : ControllerBase
    {
        private IJanitorRepo _janitorRepo;

        public JanitorController(IJanitorRepo janitorRepo)
        {
            _janitorRepo = janitorRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Janitor? entity = new();
            if (_janitorRepo is not null)
            {
                entity = await _janitorRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity.ToJanitorDto());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Janitor>? users = new();

            if (_janitorRepo != null)
            {
                users = await _janitorRepo.GetAll();
                return Ok(users.Select(janitor => janitor.ToJanitorDto()));
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateJanitorAsync(JanitorDto entity)
        {
            ControllerResponse response = new();
            if (_janitorRepo is not null)
            {
                response = await _janitorRepo.UpdateJanitorAsync(entity.ToJanitor());
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}
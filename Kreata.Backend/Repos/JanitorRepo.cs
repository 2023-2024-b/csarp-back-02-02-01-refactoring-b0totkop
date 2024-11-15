using Kreata.Backend.Context;
using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class JanitorRepo : IJanitorRepo
    {
        private readonly KretaInMemoryContext _dbContext;
        public JanitorRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Janitor>> GetAll()
        {
            return await _dbContext.Janitors.ToListAsync();
        }
        public async Task<Janitor?> GetBy(Guid id)
        {
            return await _dbContext.Janitors.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<ControllerResponse> UpdateJanitorAsync(Janitor janitor)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(janitor).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(JanitorRepo)} osztály, {nameof(UpdateJanitorAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{janitor} frissítése nem sikerült!");
            }
            return response;
        }
    }
}

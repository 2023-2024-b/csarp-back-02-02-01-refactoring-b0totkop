using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Responses;

namespace Kreata.Backend.Repos
{
    public interface IJanitorRepo
    {
        Task<List<Janitor>> GetAll();
        Task<Janitor?> GetBy(Guid id);
        Task<ControllerResponse> UpdateJanitorAsync(Janitor janitor);
    }
}

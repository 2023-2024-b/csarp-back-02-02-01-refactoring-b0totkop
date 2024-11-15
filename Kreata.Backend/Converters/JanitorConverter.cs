using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;

namespace Kreata.Backend.Converters
{
    public static class JanitorConverter
    {
        public static JanitorDto ToDto(Janitor janitor)
        {
            return new JanitorDto
            {
                Id = janitor.Id,
                FirstName = janitor.FirstName,
                LastName = janitor.LastName,
                BirthsDay = janitor.BirthsDay,
                IsWoomen = janitor.IsWoomen,
                IsAdministrator = janitor.IsAdministrator,
            };
        }

        public static Janitor ToModel(JanitorDto janitor)
        {
            return new Janitor
            {
                Id = janitor.Id,
                FirstName = janitor.FirstName,
                LastName = janitor.LastName,
                BirthsDay = janitor.BirthsDay,
                IsWoomen = janitor.IsWoomen,
                IsAdministrator = janitor.IsAdministrator,
            };
        }

        public static List<JanitorDto> GetJanitorsDtos(List<Janitor> janitors)
        {
            return janitors.Select(janitor => ToDto(janitor)).ToList();
        }

        public static List<Janitor> GetJanitors(List<JanitorDto> janitorDtos)
        {
            return janitorDtos.Select(janitorDto => ToModel(janitorDto)).ToList();
        }
    }
}

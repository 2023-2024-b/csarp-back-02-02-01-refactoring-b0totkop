using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Dtos;
using System.Threading;

namespace Kreata.Backend.Extensions
{
    public static class JanitorExtension
    {
        public static JanitorDto ToJanitorDto(this Janitor janitor)
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

        public static Janitor ToJanitor(this JanitorDto janitordto)
        {
            return new Janitor
            {
                Id = janitordto.Id,
                FirstName = janitordto.FirstName,
                LastName = janitordto.LastName,
                BirthsDay = janitordto.BirthsDay,
                IsWoomen = janitordto.IsWoomen,
                IsAdministrator = janitordto.IsAdministrator,
            };
        }
    }

}
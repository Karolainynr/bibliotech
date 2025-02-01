using Bibliotech.Api.Domain.Entities.Enums;

namespace Bibliotech.Api.Domain.Entities
{
    public class Assunto : Entity
    {
        public string Descricao {  get; set; }

        public Status Status { get; set; }
    }
}

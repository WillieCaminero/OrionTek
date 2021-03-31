using System.Collections.Generic;

namespace OrionTek.Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }

        public string Empresa { get; set; }

        public List<Client> Clients { get; set; }
    }
}

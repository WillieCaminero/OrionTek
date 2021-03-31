using System.Collections.Generic;

namespace OrionTek.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public int Empresa { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public List<Address> Addresses { get; set; }
    }
}

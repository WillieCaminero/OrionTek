namespace OrionTek.Domain.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string Calle { get; set; }

        public string Numero { get; set; }

        public string Apartamento { get; set; }

        public string Referencia { get; set; }

        public string Sector { get; set; }
    }
}

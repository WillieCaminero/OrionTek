using OrionTek.Domain.Entities;
using System.Collections.Generic;

namespace OrionTek.Domain.Interfaces.Repository
{
    public interface IClientRepository
    {
        bool CreateClient(Client client);

        bool CreateAddress(Address address);

        List<Client> GetClientsByCompanyId(int Id);

        List<Address> GetAddressesByClientId(int Id);
    }
}

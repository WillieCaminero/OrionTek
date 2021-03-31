using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Repository;
using OrionTek.Domain.Interfaces.Service;
using System.Linq;

namespace OrionTek.Domain.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IClientRepository clientRepository;

        public CompanyService(ICompanyRepository companyRepository, IClientRepository clientRepository) 
        { 
            this.companyRepository = companyRepository; 
            this.clientRepository = clientRepository; 
        }

        public bool CreateCompany(Company company) => companyRepository.CreateCompany(company);

        public Company GetCompany(int Id)
        {
            var company = companyRepository.GetCompany(Id);

            if (company == null) return company;

            company.Clients = clientRepository.GetClientsByCompanyId(company.Id);

            if (company.Clients?.Count() > 0) 
            {
                foreach (var client in company.Clients) 
                    client.Addresses = clientRepository.GetAddressesByClientId(client.Id);
            }

            return company;
        }
    }
}

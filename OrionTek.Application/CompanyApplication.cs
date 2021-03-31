using OrionTek.Domain.Entities;
using OrionTek.Domain.Interfaces.Application;
using OrionTek.Domain.Interfaces.Service;

namespace OrionTek.Application
{
    public class CompanyApplication : ICompanyApplication
    {
        private readonly ICompanyService companyService;

        public CompanyApplication(ICompanyService companyService) => this.companyService = companyService;

        public bool CreateCompany(Company company) => companyService.CreateCompany(company);

        public Company GetCompany(int Id) => companyService.GetCompany(Id);
    }
}

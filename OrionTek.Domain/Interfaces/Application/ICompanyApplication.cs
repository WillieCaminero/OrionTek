using OrionTek.Domain.Entities;

namespace OrionTek.Domain.Interfaces.Application
{
    public interface ICompanyApplication
    {
        bool CreateCompany(Company company);

        Company GetCompany(int Id);
    }
}

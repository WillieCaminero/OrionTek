using Autofac;
using OrionTek.Application;
using OrionTek.Domain.Interfaces.Application;
using OrionTek.Domain.Interfaces.Repository;
using OrionTek.Domain.Interfaces.Service;
using OrionTek.Domain.Service;
using OrionTek.Infrastructure.Repository;

namespace OrionTek.CrossCutting.InversionOfControl
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Applications
            builder.RegisterType<ClientApplication>().As<IClientApplication>();
            builder.RegisterType<CompanyApplication>().As<ICompanyApplication>();

            //Services
            builder.RegisterType<ClientService>().As<IClientService>();
            builder.RegisterType<CompanyService>().As<ICompanyService>();

            //Repositories
            builder.RegisterType<ClientRepository>().As<IClientRepository>();
            builder.RegisterType<CompanyRepository>().As<ICompanyRepository>();
        }
    }
}

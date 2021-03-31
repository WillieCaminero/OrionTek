using OrionTek.Domain.Utils;

namespace OrionTek.Infrastructure.Repository.Common
{
    public class RepAttributes
    {
        public string ConexionOrionTek
        {
            get
            {
                return AppSetting.Configuration["ConexionOrionTek"];
            }
        }

        public string Schema
        {
            get
            {
                return AppSetting.Configuration["Schema"];
            }
        }
    }
}

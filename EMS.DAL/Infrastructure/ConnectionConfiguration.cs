using System.Configuration;

namespace EMS.DAL.Infrastructure
{
    public class ConnectionConfiguration
    {
        public string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["EMS"].ConnectionString;
    }
}

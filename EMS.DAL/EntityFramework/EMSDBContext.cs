using EMS.DAL.Entities;
using EMS.DAL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL.EntityFramework
{
    public class EMSDBContext : DbContext
    {
        public EMSDBContext(ConnectionConfiguration connection) : base(connection.ConnectionString)
        {

        }

        public EMSDBContext()
        {
            Database.Connection.ConnectionString = new ConnectionConfiguration().ConnectionString;
        }
        public DbSet<Employee> Employees { get; set; }

    }
}

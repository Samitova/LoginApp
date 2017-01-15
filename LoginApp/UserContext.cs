using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class UserContext : DbContext
    {
        static UserContext()
        {
            Database.SetInitializer<UserContext>(new MyContextInitializer());
        }

        public UserContext() 
        { }
        public DbSet<User> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp
{
    class MyContextInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            User p1 = new User { Login = "Vika", Password = "123" };
            User p2 = new User { Login = "Dima", Password = "1234" };

            db.Users.Add(p1);
            db.Users.Add(p2);
            db.SaveChanges();
        }
    }
}

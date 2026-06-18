using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceActivity
{
    class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual string GetRole()
        {
            return "User";
        }
    }
}

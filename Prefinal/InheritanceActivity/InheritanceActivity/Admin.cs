using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceActivity
{
    class Admin : User
    {
        public override string GetRole()
        {
            return "Administrator";
        }
    }
}

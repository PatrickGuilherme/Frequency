using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency.Domain.Domain
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection<UserToTimeRegister> List_UserToTimeRegister { get; set; }
    }
}

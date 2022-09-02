using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency.Domain.Domain
{
    public class UserToTimeRegister
    {
        public int ID_TimeRegister { get; set; }
        public virtual TimeRegister TimeRegister { get; set; }
        public int ID_User { get; set; }
        public virtual User User { get; set; }
    }
}

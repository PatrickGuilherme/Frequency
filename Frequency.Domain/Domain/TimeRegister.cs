using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency.Domain.Domain
{
    public class TimeRegister
    {
        public int ID { get; set; }
        public DateTime InputTime { get; set; }
        public DateTime OutputTime { get; set; }
        public DateTime InputBreaktTime { get; set; }
        public DateTime OutputBreakTime { get; set; }
        public int Shift { get; set; }//TURNO
        public DateTime PendingTime { get; set; }
        public DateTime ExtraTime { get; set; }
        public DateTime DateRegister { get; set; }
        public virtual ICollection<UserToTimeRegister> List_UserToTimeRegister { get; set; }

    }
}

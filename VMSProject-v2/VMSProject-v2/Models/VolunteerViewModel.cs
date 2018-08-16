using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSProjectV2.Models
{
    public class VolunteerViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public List<string> Skills = new List<string>();
        public string MainSkill { get; set; }
        public string VolunteerOpp { get; set; }
    }
}

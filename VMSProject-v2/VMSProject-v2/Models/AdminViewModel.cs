using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSProjectV2.Models
{
    public class AdminViewModel
    {
        public string Email { get; set; }
        public List<VolunteerViewModel> Volunteers = new List<VolunteerViewModel>();

        public AdminViewModel()
        {
            Volunteers firstVol = new Volunteers();
            Volunteers.Add(firstVol.Myisha);
        }
    }
}

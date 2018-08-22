using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSProjectV2.Models
{
    public class Volunteers
    {
        public VolunteerViewModel Myisha = new VolunteerViewModel();

        public Volunteers()
        {
            Myisha.FirstName = "Myisha";
            Myisha.LastName = "Kinberg";
            Myisha.Username = "Mkinberg";
            Myisha.Password = "Password";
            Myisha.Centers.Add("Humane Society");
            Myisha.Skills.Add("Leadership");
            Myisha.AvailabilityDays.Add("Saturday");
            Myisha.AvailabilityTimes.Add("noon - 5pm");
            Myisha.Address = "120 UNF Drive";
            Myisha.City = "Jax";
            Myisha.State = "Florida";
            Myisha.Zip = 1234;
            Myisha.HomePhone = 9876543210;
            Myisha.Email = "mkinberg@gmail.com";
            Myisha.Education.Add("Associates");
            Myisha.Licenses.Add("None");
            Myisha.DriversLicence = true;
            Myisha.SSN = true;
            Myisha.ApprovalStatus.Add("Approved");
            Myisha.EmergencyName = "Megan Fern";
            Myisha.EmergencyEmail = "megs@gmail.com";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSProjectV2.Models
{
    public class Volunteers
    {
        public VolunteerViewModel Myisha = new VolunteerViewModel();
        public VolunteerViewModel Jack = new VolunteerViewModel();
        public VolunteerViewModel Sam = new VolunteerViewModel();

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
            Myisha.ApprovalStatus.Add("Pending Approval");
            Myisha.EmergencyName = "Megan Fern";
            Myisha.EmergencyEmail = "megs@gmail.com";

            Jack.FirstName = "Jack";
            Jack.LastName = "Tom";
            Jack.Username = "JTom";
            Jack.Password = "Password";
            Jack.Centers.Add("Humane Society");
            Jack.Skills.Add("Leadership");
            Jack.AvailabilityDays.Add("Monday");
            Jack.AvailabilityTimes.Add("8am - noon");
            Jack.Address = "120 UNF Drive";
            Jack.City = "Jax";
            Jack.State = "Florida";
            Jack.Zip = 1234;
            Jack.HomePhone = 9876543210;
            Jack.Email = "jtom@gmail.com";
            Jack.Education.Add("Master");
            Jack.Licenses.Add("None");
            Jack.DriversLicence = true;
            Jack.SSN = false;
            Jack.ApprovalStatus.Add("Pending Approval");
            Jack.EmergencyName = "James Tom";
            Jack.EmergencyEmail = "tom@gmail.com";

            Sam.FirstName = "Sam";
            Sam.LastName = "Thomas";
            Sam.Username = "SThomas";
            Sam.Password = "Password";
            Sam.Centers.Add("Humane Society");
            Sam.Skills.Add("Leadership");
            Sam.AvailabilityDays.Add("Saturday");
            Sam.AvailabilityTimes.Add("noon - 5pm");
            Sam.Address = "120 UNF Drive";
            Sam.City = "Jax";
            Sam.State = "Florida";
            Sam.Zip = 1234;
            Sam.HomePhone = 727272727;
            Sam.Email = "samthomas@gmail.com";
            Sam.Education.Add("Associates");
            Sam.Licenses.Add("None");
            Sam.DriversLicence = false;
            Sam.SSN = false;
            Sam.ApprovalStatus.Add("Disapproved");
            Sam.EmergencyName = "Thomas Sam";
            Sam.EmergencyEmail = "tsams@gmail.com";
        }
    }
}

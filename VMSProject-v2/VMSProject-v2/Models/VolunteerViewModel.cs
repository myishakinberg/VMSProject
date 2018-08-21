using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMSProjectV2.Models
{
    public class VolunteerViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<string> Centers = new List<string>();
        public List<string> Skills = new List<string>();
        public List<string> AvailabilityDays = new List<string>();
        public List<string> AvailabilityTimes = new List<string>();
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int HomePhone { get; set; }
        public int CellPhone { get; set; }
        public int WorkPhone { get; set; }
        public string Email { get; set; }
        public List<string> Education = new List<string>();
        public List<string> Licenses = new List<string>();
        public bool DriversLicence { get; set; } 
        public bool SSN { get; set; } 
        public List<string> ApprovalStatus = new List<string>();

        public string EmergencyName { get; set; }
        public string EmergencyAddress { get; set; }
        public string EmergencyCity { get; set; }
        public string EmergencyState { get; set; }
        public int EmergencyZip { get; set; }
        public int EmergencyHomePhone { get; set; }
        public int EmergencyWorkPhone { get; set; }
        public string EmergencyEmail { get; set; }

        public VolunteerViewModel()
        {
            Centers.Add("Five STAR Veterans ");
            Centers.Add("CIS JAX");
            Centers.Add("Humane Society");
            Centers.Add("Women's Homeless Shelter");
            Centers.Add("Hubbard House Hope & Healing");
            Centers.Add("UNF School of Computing");

            Skills.Add("Organization");
            Skills.Add("Flexibility");
            Skills.Add("Technical Skills");
            Skills.Add("Leadership");
            Skills.Add("Adaptability");

            AvailabilityDays.Add("Monday");
            AvailabilityDays.Add("Tuesday");
            AvailabilityDays.Add("Wednesday");
            AvailabilityDays.Add("Thursday");
            AvailabilityDays.Add("Friday");
            AvailabilityDays.Add("Saturday");
            AvailabilityDays.Add("Sunday");

            AvailabilityTimes.Add("8am - noon");
            AvailabilityTimes.Add("noon - 5pm");
            AvailabilityTimes.Add("5pm - 10pm");

            Education.Add("Some High School");
            Education.Add("High School Diploma");
            Education.Add("Some College");
            Education.Add("Associates");
            Education.Add("Bachlores");
            Education.Add("Masters");
            Education.Add("Doctorate");

            Licenses.Add("Certified Financial Planner");
            Licenses.Add("Certified Public Accountant");
            Licenses.Add("Financial Risk Manager");
            Licenses.Add("Other");
            Licenses.Add("None");

            ApprovalStatus.Add("Approved");
            ApprovalStatus.Add("Pending Approval");
            ApprovalStatus.Add("Disapproved");
            ApprovalStatus.Add("Inactive");

        }
    }
}

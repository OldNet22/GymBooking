﻿namespace GymBooking.Web.Models.Entities
#nullable disable
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }
        public DateTime EndTime => StartDate + Duration;

        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } 
    }
}

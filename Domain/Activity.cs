using System;

// entities framework = object relation marker
namespace Domain
{
    public class Activity
    {
        // properties that will form column inside Table Activity in Db
        public Guid Id { get; set; }    // guid: generate from server / client side
                                        // primary key
        public string Title { get; set; }   
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; } 
    }
}
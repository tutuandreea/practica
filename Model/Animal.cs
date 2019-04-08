using System;

namespace WebApi
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public DateTime AdoptionDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public int SpeciesId { get; set; }
        public Species Species { get; set; }
        public int CaretakerId { get; set; }
        public virtual Caretaker Caretaker {get; set;}
        public Age Age { get; set; }
        public Health Health {get; set;}
    }
}
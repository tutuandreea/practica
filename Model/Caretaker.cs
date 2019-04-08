using System;
using System.Collections.Generic;

namespace WebApi
{
    public class Caretaker: IPerson
    {
        public int CaretakerId { get; set; }
        public int? BossId { get; set; }
        public Caretaker Boss { get; set; }
        public DateTime EmployDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Animal> Animals { get; set; }
        public ICollection<Caretaker> Subalterni { get; set; }
    }
}
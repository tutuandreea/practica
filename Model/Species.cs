using System.Collections.Generic;

namespace WebApi
{
    public class Species
    {
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
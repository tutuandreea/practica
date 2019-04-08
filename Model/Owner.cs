using System.Collections.Generic;

namespace WebApi
{
    public class Owner: IPerson
    {
        public int OwnerId { get; set; }
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
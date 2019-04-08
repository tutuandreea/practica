using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public interface IPerson
    {
        string Name { get; set; }
        string Email { get; set; }
        ICollection<Animal> Animals { get; set; }
    } 
}
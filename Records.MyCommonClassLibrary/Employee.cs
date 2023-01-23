using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.MyCommonClassLibrary
{
    public record Employee
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public DateOnly Dob { get; init; }
        public void Deconstruct(out int id, out string name, out DateOnly dob)
        {
            id = Id;
            name = Name;
            dob = Dob;
        }
    }
}

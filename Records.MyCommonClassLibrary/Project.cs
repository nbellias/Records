using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records.MyCommonClassLibrary
{
    public record Project(int Id, string Name, DateTime StartDate, DateTime? FinishDate)
    {
        public void Deconstruct(out int id, out string name, out DateTime startDate, out DateTime? finishDate)
        {
            id = Id;
            name = Name;
            startDate = StartDate;
            finishDate = FinishDate;
        }
    }
}

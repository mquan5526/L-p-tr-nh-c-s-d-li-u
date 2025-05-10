using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Class { get; set; }
        public string EnNO { get; set; }
        public string Gender { get; set; }

        public Student ( int id, string name, string age, string @class, string enNO, string gender)
        {
            Id = id;
            Name = name;
            Age = age;
            Class = @class;
            EnNO = enNO;
            Gender = gender;
        }
    }
}

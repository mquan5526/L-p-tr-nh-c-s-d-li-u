using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Gender { get; set; } 
        public string Address { get; set; }
        public Worker(int id, string name, int age, string position, string gender, string address)
        {
            Id = id;
            Name = name;
            Age = age;
            Position = position;
            Gender = gender;
            Address = address;
        }
    }
}

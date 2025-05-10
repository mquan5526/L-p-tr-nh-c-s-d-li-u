using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Subject { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public Teacher(int id, string name, int age, string subject, string gender, string address) 
        {
            Id = id;
            Name = name;
            Age = age;
            Subject = subject;
            Gender = gender;
            Address = address;
        }
    }
}

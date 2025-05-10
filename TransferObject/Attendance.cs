using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Attendance
    {
        public int Id { get; set; }
        public string StName { get; set; }
        public DateTime Date { get; set; }
        public string StStatus { get; set; }
        public Attendance (int id, string name, DateTime date, string status)
        {
            Id = id;
            StName = name;
            Date = date;
            StStatus = status;
        }
    }
}

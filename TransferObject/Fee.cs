using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Fee
    {
        public int Id { get; set; }
        public string StName { get; set; }
        public string EnNo {  get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public Fee(int id, string name, string enno, DateTime date, int amount)
        {
            Id = id;
            StName = name;
            EnNo = enno;
            Date = date;
            Amount = amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class FeeBL
    {
        private FeeDL feeDL;
        public FeeBL()
        {
            feeDL = new FeeDL();
        }
        public List<Fee> GetFees()
        {
            try
            {
                return feeDL.GetFees();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Add(Fee fee)
        {
            try
            {
                return feeDL.AddFee(fee);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

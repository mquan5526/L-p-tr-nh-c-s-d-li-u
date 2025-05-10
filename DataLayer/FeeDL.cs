using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class FeeDL:DataProvider
    {
        public List<Fee> GetFees()
        {
            int id, amount;
            string name, enno;
            DateTime date;
            List<Fee> fees = new List<Fee>();
            string sql = "select * from FeesTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, System.Data.CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = reader["StName"].ToString();
                    date = Convert.ToDateTime(reader["Date"]);
                    enno = reader[2].ToString();
                    amount = Convert.ToInt32(reader[4]);

                    Fee fee = new Fee(id, name, enno, date, amount);
                    fees.Add(fee);
                }
                reader.Close();
                return fees;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                Disconnect();
            }
        }
        public int AddFee(Fee fee)
        {
            string sql = "insert into FeesTable(Id, StName, EnNo, Date, Amount) values ('" + fee.Id + "', '" + fee.StName + "', '" + fee.EnNo + "', '" + fee.Date + "', '" + fee.Amount + "')";
            try
            {
                return MyExecuteNonQuery(sql, System.Data.CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

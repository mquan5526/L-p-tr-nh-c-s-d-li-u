using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class LoginDL:DataProvider
    {
        public bool Login(Account account)
        {
            string sql = "select count(Username) from RegisterTable where Username = '" + account.Username + "' and Password ='" + account.Password + "'";
            try
            {
                Connect();
                return ((int)(MyExecuteScalar(sql, CommandType.Text)) > 0);
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
    }
}

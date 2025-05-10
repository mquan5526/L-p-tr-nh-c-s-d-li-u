using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TransferObject;
using System.Data;

namespace DataLayer
{
    public class RegistrationDL:DataProvider
    {
        public List<Registration> GetRegistrations()
        {
            string name, user, password, cpassword;
            List<Registration> registrations = new List<Registration>();
            string sql = "select * from RegisterTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    name = reader[0].ToString();
                    user = reader[1].ToString();
                    password = reader[2].ToString();
                    cpassword = reader[3].ToString();

                    Registration registration = new Registration(name, user, password, cpassword);
                    registrations.Add(registration);
                }
                reader.Close();
                return registrations;
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

        public int AddRegistration (Registration registration)
        {
            string sql = "insert into RegisterTable(FName, Username, Password, CPassword) values ('" + registration.Name + "', '" + registration.User + "', '" + registration.Password + "', '" + registration.Cpassword + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

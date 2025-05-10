using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class AttendanceDL:DataProvider
    {
        public List<Attendance> GetAttendances()
        {
            int id;
            string name, status;
            DateTime date;
            List<Attendance> attendances = new List<Attendance>();
            string sql = "select * from AttendanceTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, System.Data.CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = reader["StName"].ToString();
                    date = Convert.ToDateTime(reader["Date"]);
                    status = reader[3].ToString();

                    Attendance attendance = new Attendance(id, name, date, status);
                    attendances.Add(attendance);
                }
                reader.Close();
                return attendances;
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
        public int AddAttendance(Attendance attendance)
        {
            string sql = "insert into AttendanceTable(Id, StName, Date, StStatus) values ('" + attendance.Id + "', '" + attendance.StName + "', '" + attendance.Date + "', '" + attendance.StStatus + "')";
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

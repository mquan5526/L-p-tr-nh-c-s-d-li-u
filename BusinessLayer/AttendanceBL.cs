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
    public class AttendanceBL
    {
        private AttendanceDL attendanceDL;
        public AttendanceBL()
        {
            attendanceDL = new AttendanceDL();
        }
        public List<Attendance> GetAttendances()
        {
            try
            {
                return attendanceDL.GetAttendances();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Add(Attendance attendance)
        {
            try
            {
                return attendanceDL.AddAttendance(attendance);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

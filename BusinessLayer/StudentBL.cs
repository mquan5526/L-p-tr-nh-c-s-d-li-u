using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class StudentBL
    {
        private StudentDL studentDL;
        public StudentBL()
        {
            studentDL = new StudentDL();
        }

        public List<Student> GetStudents()
        {
            try
            {
                return studentDL.GetStudents();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Add(Student student)
        {
            try
            {
                return studentDL.AddStudent(student);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Student student)
        {
            try
            {
                return studentDL.UpdateStudent(student);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteStudent(int id)
        {
            try
            {
                return studentDL.DeleteStudent(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

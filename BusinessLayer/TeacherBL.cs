using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class TeacherBL
    {
        private TeacherDL teacherDL;
        public TeacherBL()
        {
            teacherDL = new TeacherDL();
        }

        public List<Teacher> GetTeachers()
        {
            try
            {
                return teacherDL.GetTeachers();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Add(Teacher teacher)
        {
            try
            {
                return teacherDL.AddTeacher(teacher);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteTeacher(int id)
        {
            try
            {
                return teacherDL.DeleteTeacher(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Teacher teacher)
        {
            try
            {
                return teacherDL.UpdateTeacher(teacher);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

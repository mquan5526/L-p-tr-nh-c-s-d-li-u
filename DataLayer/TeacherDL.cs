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
    public class TeacherDL:DataProvider
    {
        public List<Teacher> GetTeachers()
        {
            int id, age;
            string name, subject, gender, address;
            List<Teacher> teachers = new List<Teacher>();
            string sql = "select * from TeacherTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = reader["Name"].ToString();
                    age = reader[2].GetHashCode();
                    subject = reader[3].ToString();
                    gender = reader[4].ToString();
                    address = reader[5].ToString();

                    Teacher teacher = new Teacher(id, name, age, subject, gender, address);
                    teachers.Add(teacher);
                }
                reader.Close();
                return teachers;
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
        public int AddTeacher(Teacher teacher)
        {
            string sql = "insert into TeacherTable(Id, Name, Age, Subject, Gender, Address) values (" + teacher.Id + ", '" + teacher.Name + "', " + teacher.Age + ", '" + teacher.Subject + "', '" + teacher.Gender + "', '" + teacher.Address + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteTeacher(int id)
        {
            string sql = string.Format("delete from TeacherTable where Id = {0}", id);
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateTeacher(Teacher teacher)
        {
            string sql = "update TeacherTable set Name = '" + teacher.Name + "', Age = '" + teacher.Age + "', Subject = '" + teacher.Subject + "', Gender = '" + teacher.Gender + "', Address = '" + teacher.Address + "' WHERE Id = " + teacher.Id;

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

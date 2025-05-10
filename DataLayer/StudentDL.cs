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
    public class StudentDL:DataProvider
    {
        public List<Student> GetStudents()
        {
            int id;
            string name, age, @class, enNO, gender;
            List<Student> students = new List<Student>();
            string sql = "select * from StTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = reader["Name"].ToString();
                    age = reader[2].ToString();
                    @class = reader[3].ToString();
                    enNO = reader[4].ToString();
                    gender = reader[5].ToString();

                    Student student = new Student(id, name, age, @class, enNO, gender);
                    students.Add(student);
                }
                reader.Close();
                return students;
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

        public int AddStudent(Student student)
        {
            string sql = "insert into StTable(Id, Name, Age, Class, EnNO, Gender) values ('" + student.Id + "', '" + student.Name + "', '" + student.Age + "', '" + student.Class + "', '" + student.EnNO + "', '" + student.Gender + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateStudent(Student student)
        {
            string sql = "update StTable set Name = '" + student.Name + "', Age = '" + student.Age + "', Class = '" + student.Class + "', EnNO = '" + student.EnNO + "', Gender = '" + student.Gender + "' WHERE Id = " + student.Id;
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteStudent(int id)
        {
            string sql = string.Format("delete from StTable where Id = {0}", id);
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

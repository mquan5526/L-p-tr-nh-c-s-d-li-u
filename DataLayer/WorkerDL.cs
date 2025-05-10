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
    public class WorkerDL:DataProvider
    {
        public List<Worker> GetWorkers()
        {
            int id, age;
            string name, position, gender, address;
            List<Worker> workers = new List<Worker>();
            string sql = "select * from WorkerTable";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["Id"]);
                    name = reader["Name"].ToString();
                    age = Convert.ToInt32(reader[2]);
                    position = reader[3].ToString();
                    gender = reader[4].ToString();
                    address = reader[5].ToString();

                    Worker worker = new Worker(id, name, age, position, gender, address);
                    workers.Add(worker);
                }
                reader.Close();
                return workers;
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
        public int AddWorker(Worker worker)
        {
            string sql = "insert into WorkerTable(Id, Name, Age, Position, Gender, Address) values (" + worker.Id  + ", '" + worker.Name + "', " + worker.Age + ", '" + worker.Position + "', '" + worker.Gender + "', '" + worker.Address + "')";
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteWorker(int id)
        {
            string sql = string.Format("delete from WorkerTable where Id = {0}", id);
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateWorker(Worker worker)
        {
            string sql = "update WorkerTable set Name = '" + worker.Name + "', Age = '" + worker.Age + "', Position = '" + worker.Position + "', Gender = '" + worker.Gender + "', Address = '" + worker.Address + "' WHERE Id = " + worker.Id;

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

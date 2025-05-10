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
    public class WorkerBL
    {
        private WorkerDL workerDL;
        public WorkerBL()
        {
            workerDL = new WorkerDL();
        }
        public List<Worker> GetWorkers()
        {
            try
            {
                return workerDL.GetWorkers();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Add(Worker worker)
        {
            try
            {
                return workerDL.AddWorker(worker);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteWorker(int id)
        {
            try
            {
                return workerDL.DeleteWorker(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Worker worker)
        {
            try
            {
                return workerDL.UpdateWorker(worker);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

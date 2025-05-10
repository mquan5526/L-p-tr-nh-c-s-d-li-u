using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
using System.Data.SqlClient;
using DataLayer;

namespace BusinessLayer
{
    public class RegistrationBL
    {
        private RegistrationDL registrationDL;

        public RegistrationBL()
        {
            registrationDL = new RegistrationDL();
        }

        public List<Registration> GetRegistrations()
        {
            try
            {
                return registrationDL.GetRegistrations();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Registration registration)
        {
            try
            {
                return registrationDL.AddRegistration(registration);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

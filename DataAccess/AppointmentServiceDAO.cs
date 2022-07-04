using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentServiceDAO
    {
        private static AppointmentServiceDAO instance;
        private static readonly object instanceLock = new object();
        private AppointmentServiceDAO() { }
        public static AppointmentServiceDAO Instance { 
            get {
                lock (instanceLock) {
                    if (instance == null) 
                    { 
                        instance = new AppointmentServiceDAO();
                    }
                    return instance;
                }
            } 
        }

        public List<AppointmentService> GetAppointmentServiceListByAppointmentId(int id) {
            try
            {
                using (DBSContext DBSContext = new DBSContext()) { 
                    return DBSContext.AppointmentServices.Where(x => x.AppointmentId == id).ToList();
                }
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
        }

    }
}

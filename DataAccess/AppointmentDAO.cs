using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentDAO
    {
        private static AppointmentDAO instance;
        private static readonly object instanceLock = new object();
        private AppointmentDAO() { }
        public static AppointmentDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new AppointmentDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Appointment> GetAppointmentList(DateTime time, string phone, int dentistId, int status)
        {
            try
            {
                using(DBSContext DBSContext = new DBSContext())
                {
                    return (
                        from a in DBSContext.Appointments
                        join c in DBSContext.Customers on a.CustomerId equals c.Id
                        where 
                            a.Time == time && 
                            c.Phone.Contains(phone) && 
                            (a.DentistId == dentistId || dentistId == 0) && 
                            (a.Status == status || status == 0)
                        select a
                    ).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Appointment GetAppointmentById(int id)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    return DBSContext.Appointments.FirstOrDefault(c => c.Id == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<string> GetWorkingTimeListByDateAndDentist(DateTime time, int dentistId)
        {
            try
            {
                using (DBSContext DBSContext = new DBSContext())
                {
                    return DBSContext.Appointments.Where(a => a.Time == time && a.DentistId == dentistId)
                        .Select(a => a.WorkingHour).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

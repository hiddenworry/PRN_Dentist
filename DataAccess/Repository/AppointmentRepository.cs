using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public Appointment GetAppointmentById(int id)
        {
            return AppointmentDAO.Instance.GetAppointmentById(id);
        }

        public List<Appointment> GetAppointmentList(DateTime date, string phone, int dentistId, int status)
        {
            return AppointmentDAO.Instance.GetAppointmentList(date, phone, dentistId, status);
        }
        //public List<string> GetTimeOptionByDate(DateTime time){

        //}
    }
}

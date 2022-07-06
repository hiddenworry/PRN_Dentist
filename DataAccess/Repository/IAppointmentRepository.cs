using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAppointmentRepository
    {
        List<Appointment> GetAppointmentList(DateTime date, string phone, int dentistId, int status);
        List<Appointment> GetAppointmentByStatus( int status);
        Appointment GetAppointmentById(int id);
        List<string> GetTimeOptionByDate(DateTime time, List<Service> serviceList);


        List<Appointment> GetAppointmentsForAdmin();

        Appointment GetAppointmentNearest();

        void UpdateAppointment(Appointment appointment);

        List<Appointment> Get10FistappointmentDoneCustomerById(int id);

        void UpdateAppointmentByDoctor(Appointment appointment);
    }
}

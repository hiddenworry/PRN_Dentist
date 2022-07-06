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
<<<<<<< HEAD
        List<string> GetTimeOptionByDate(DateTime time, List<Service> serviceList, Appointment appointment);
        Appointment AddAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        int GetGetSuitableDentistByDate(DateTime time, List<Service> serviceList, string newWorkingHour, Appointment appointment);
        Appointment GetWaitingAppointmentByCustomerId(int id);
=======
        List<string> GetTimeOptionByDate(DateTime time, List<Service> serviceList);


        List<Appointment> GetAppointmentsForAdmin();

        Appointment GetAppointmentNearest();

        void UpdateAppointment(Appointment appointment);

        List<Appointment> Get10FistappointmentDoneCustomerById(int id);

        void UpdateAppointmentByDoctor(Appointment appointment);
>>>>>>> 42cc2ba450d82ce0b28a1449cbf15841d63a84f6
    }
}

using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        public List<string> GetTimeOptionByDate(DateTime time, List<Service> serviceList)
        {
            double totalTime = 0;
            foreach (Service service in serviceList)
            {
                totalTime = totalTime + service.EstimatedTime;
            }
            DateTime openTime = DateTime.ParseExact("07:00", "HH:mm", CultureInfo.InvariantCulture);
            DateTime closeTime = DateTime.ParseExact("19:00", "HH:mm", CultureInfo.InvariantCulture);
            DateTime start = openTime;
            DateTime end;
            
            List<string> availableOptions = new List<string>();

            foreach(Account account in new AccountRepository().GetActiveDentistList())
            {
                List<string> options = new List<string>();
                List<string> workingHourList = AppointmentDAO.Instance.GetWorkingTimeListByDateAndDentist(time, account.Id);

                while (true)
                {
                    end = start.AddMinutes(totalTime * 60);
                    if (end > closeTime) break;
                    DateTime workingStart;
                    DateTime workingEnd;
                    foreach (string workingHour in workingHourList)
                    {
                        workingStart = DateTime.ParseExact(workingHour.Split('-')[0], "HH:mm", CultureInfo.InvariantCulture);
                        workingEnd = DateTime.ParseExact(workingHour.Split('-')[1], "HH:mm", CultureInfo.InvariantCulture);

                        if ((workingStart < end) && (workingEnd > start)) break;

                        options.Add(start.ToString("HH:mm") + "-" + end.ToString("HH:mm"));
                        start = start.AddMinutes(30);
                    }
                }

                availableOptions = availableOptions.Union(options).ToList();
            }
            return availableOptions;
        }
    }
}

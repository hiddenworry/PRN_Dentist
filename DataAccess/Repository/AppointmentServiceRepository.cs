using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentServiceRepository : IAppointmentServiceRepository
    {
        public List<AppointmentService> GetAppointmentServiceListByAppointmentId(int id)
        {
            return AppointmentServiceDAO.Instance.GetAppointmentServiceListByAppointmentId(id);
        }
    }
}

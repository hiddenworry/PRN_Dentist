﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public List<Appointment> GetAppointmentList(DateTime date, string phone, string dentistName, string status)
        {
            throw new NotImplementedException();
        }
    }
}

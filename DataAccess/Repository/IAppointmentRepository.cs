﻿using BusinessObject.Models;
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
        Appointment GetAppointmentById(int id);
    }
}

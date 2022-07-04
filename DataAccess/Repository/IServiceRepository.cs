﻿using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IServiceRepository
    {
        List<Service> GetServices();
        void SaveService(Service service);

        void UpdateService(Service service);

        List<Service> GetServiceFromServiceType(int ServiceTypeId);
    }
}
}

using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceRepository : IServiceRepository
    {
        public List<Service> GetServiceFromServiceType(int ServiceTypeId) => ServiceDAO.GetServiceFromServiceType(ServiceTypeId);
      

        public List<Service> GetServices() => ServiceDAO.GetServices();

        public void SaveService(Service service) => ServiceDAO.SaveService(service);

        public void UpdateService(Service service) => ServiceDAO.UpdateService(service);



    }
}

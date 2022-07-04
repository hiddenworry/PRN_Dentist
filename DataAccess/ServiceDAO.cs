using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDAO { 
        private static ServiceDAO instance;
        private static readonly object instancelock = new object();
        private ServiceDAO() { }
        public static ServiceDAO Instance { 
            get {
                lock (instancelock) {
                    if (instance == null) { 
                        instance = new ServiceDAO();
                    }
                    return instance;
                }
            }
        }

         public List<Service> GetServices()
    {
        var ServiceList = new List<Service>();
        try
        {
            using (var Context = new DBSContext())
            {
                ServiceList = Context.Services.ToList();
            }

        }
        catch (Exception ex)
        {

        }
        return ServiceList;
    }

        public List<Service> GetServiceFromServiceType(int ServiceTypeId)
        {
            var ServiceList = new List<Service>();
            try
            {
                using (var Context = new DBSContext())
                {
                    ServiceList = Context.Services.Where(s => s.ServiceTypeId == ServiceTypeId).ToList();
                }

            }
            catch (Exception ex)
            {

            }
            return ServiceList;

        }

    public void SaveService(Service service)
    {

        try
        {
            using (var Context = new DBSContext())
            {
                Context.Services.Add(service);
                Context.SaveChanges();

            }

        }
        catch (Exception ex)
        {

        }

    }

    public void UpdateService(Service service)
    {

        try
        {
            using (var Context = new DBSContext())
            {
                Context.Entry<Service>(service).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            }

        }
        catch (Exception ex) { }


    }

        public List<Service> GetActiveServiceList()
        {
            try
            {
                using (var Context = new DBSContext())
                {
                    return Context.Services.Where(s => s.Status == 1).ToList();
                }
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message);
            }
        }
    }
}

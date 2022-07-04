using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ServiceDAO { 


         public static List<Service> GetServices()
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

        public static List<Service> GetServiceFromServiceType(int ServiceTypeId)
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

    public static void SaveService(Service service)
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

    public static void UpdateService(Service service)
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
}
}

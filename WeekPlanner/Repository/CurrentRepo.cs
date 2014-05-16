using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeekPlanner.Repository
{
    public class CurrentRepo
    {
        private static IRepository _repo;

        public static IRepository Repo
        {
            get
            {
                if(_repo == null)
                {
                    throw new ApplicationException("Repository was not set.");
                }

                return _repo;
            }
        }


        internal static void InitRepo(string typeName)
        {
            var loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach(var assembly in loadedAssemblies)
            {
                var typesMathingInterface = assembly.GetTypes().Where(t => typeof(IRepository).IsAssignableFrom(t));
            }
        }
    }
}
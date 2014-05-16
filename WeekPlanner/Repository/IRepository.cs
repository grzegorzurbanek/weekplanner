using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeekPlanner.Models;

namespace WeekPlanner.Repository
{
    public interface IRepository
    {
        void RegisterRepository(IRepository repo);

        IEnumerable<Task> GetTasksForDay(DateTime day);

    }
}
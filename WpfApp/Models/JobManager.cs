using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public class JobManager
    {
        public static ObservableCollection<Job> _JobDatabase = new ObservableCollection<Job>() { new Job {Title = "DevOps Engineer", Location = "Seattle, WA", Description = "Lorem..."}, new Job {Title = "Software Engineer", Location = "San Francisco, CA", Description = "Lorem..."}, new Job {Title = "Project Manager", Location = "El Segundo, CA", Description = "Lorem.." } };

        public static ObservableCollection<Job> GetJobs()
        {
            return _JobDatabase;
        }

        public static void AddJob(Job job)
        {
            _JobDatabase.Add(job);
        }
    }
}

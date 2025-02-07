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
        public static ObservableCollection<Job> _JobDatabase = new ObservableCollection<Job>() { new Job {Title = "DevOps Engineer", Description = "Lorem..."}, new Job {Title = "Software Engineer", Description = "Lorem..."}, new Job {Title = "Project Manager", Description = "Lorem.." } };

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

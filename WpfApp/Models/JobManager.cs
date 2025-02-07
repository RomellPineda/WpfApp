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
        public static ObservableCollection<Job> _JobDatabase = new ObservableCollection<Job>() { new Job {Title = "DevOps Engineer", Location = "Seattle, WA", Description = "Lorem...", DatePosted = "01-10-2025"}, new Job {Title = "Software Engineer", Location = "San Francisco, CA", Description = "Lorem...", DatePosted = "01-15-2025" }, new Job {Title = "Project Manager", Location = "El Segundo, CA", Description = "Lorem..", DatePosted = "01-05-2025" } };

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

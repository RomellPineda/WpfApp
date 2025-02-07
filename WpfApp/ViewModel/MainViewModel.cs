using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.Commands;
using WpfApp.Models;
using WpfApp.Views;

namespace WpfApp.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<Job> Jobs { get; set; }

        public ICommand ShowWindowCommand { get; set; }

        public MainViewModel()
        {
            Jobs = JobManager.GetJobs();
            ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
        }

        private bool CanShowWindow(object obj)
        {
            return true;
        }

        private void ShowWindow(object obj)
        {
            ApplyToJob applyToJob = new ApplyToJob();
            applyToJob.Show();
        }
    }
}

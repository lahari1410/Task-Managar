using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Hey = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> hey;

        [ObservableProperty]
        Task task = new();

        [ObservableProperty]
        ObservableCollection<Task> tasklist;
        public ObservableCollection<Task> TaskList
        {
            get { return tasklist; }
            set { tasklist = value; }
        }

        

        [ICommand]
        void AddTask()
        {
            string str;
            if(string.IsNullOrEmpty(task.Name)) { return; }
            if (Task.Reminder)
            {
                str = Task.Name + "  " + Task.Description + "  You will get a reminder at : " + Task.Time;
            }else
            {
                str = Task.Name + "  " + Task.Description + "    " + Task.Time;
            }
            

            hey.Add(str);
        }

        [ICommand]
        void Delete(string s)
        {
            if (hey.Contains(s))
            {
                hey.Remove(s);
            }
        }

        [ICommand]
        void Yes()
        {
            
            Task.Reminder = true;
        }

        [ICommand]
        void No()
        {
            Task.Reminder = false;
        }

    }

    
}

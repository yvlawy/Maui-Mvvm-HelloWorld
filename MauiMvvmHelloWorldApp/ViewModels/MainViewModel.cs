using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMvvmHelloWorldApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private int count = 0;

        public MainViewModel()
        {
            IncrementCommand = new Command(() =>
            {
                count++;
                OnPropertyChanged("CountText");
            });
        }
        public ICommand IncrementCommand { get; private set; }


        public string Title
        {
            get { return "Hello World!!"; }
        }

        public string CountText
        {
            get { return "Current count: " + count.ToString(); }
        }
    }
}

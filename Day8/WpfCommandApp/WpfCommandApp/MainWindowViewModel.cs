using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfCommandApp
{
    class MainWindowViewModel
    {
        public ICommand MainWindowCommand { get; set; }

        public MainWindowViewModel() {

            MainWindowCommand  = new DisplayCommand();

            //MainWindowCommand = new DatabaseCommand();
        }
    }
}

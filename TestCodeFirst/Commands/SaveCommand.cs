using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TestCodeFirst.ViewModels;

namespace TestCodeFirst.Commands
{
    public class SaveCommand : ICommand
    {
        private readonly CodeFirstContext cfc;
        public event EventHandler CanExecuteChanged;

        public SaveCommand(CodeFirstContext cfc)
        {
            this.cfc = cfc;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            cfc.SaveChanges();
        }
    }
}

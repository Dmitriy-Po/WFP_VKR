using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestCodeFirst.Commands
{
    public class UpdateCommand : ICommand
    {
        private Action updateDayOfNorm;

        public UpdateCommand(Action updateDayOfNorm)
        {
            this.updateDayOfNorm = updateDayOfNorm;
        }

        public event EventHandler CanExecuteChanged;
        


        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            updateDayOfNorm();
        }
    }
}

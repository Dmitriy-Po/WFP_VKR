using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TestCodeFirst.Commands
{
    public class CreateDataListCommand : ICommand
    {
        private readonly Action updateDataResult;

        public CreateDataListCommand(Action updateDataResult)
        {
            this.updateDataResult = updateDataResult;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            updateDataResult.Invoke();
        }
    }
}

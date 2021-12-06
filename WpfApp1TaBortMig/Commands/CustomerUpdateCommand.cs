

using System;
using System.Windows.Input;
using WpfApp1TaBortMig.ViewModels;

namespace WpfApp1TaBortMig.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        private CustomerViewModel _viewModel;
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(object parameter)
        {
            _viewModel.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandLib
{
    public abstract class AsyncCommandBase : IAsyncCommand, INotifyPropertyChanged
    {
        #region Implementation IAsyncCommand
        public abstract bool CanExecute(object parameter);
        public abstract Task ExecuteAsync(object parameter);

        public async void Execute(object parameter)
        {
            await ExecuteAsync(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        #endregion

        /// <summary>
        /// Introduce a method for forced renewal RequerySuggested
        /// </summary>
        protected void RaiseCanExecuteChanged()
        {
            CommandManager.InvalidateRequerySuggested();
        }

        #region Implementation INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string Parameter = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Parameter));
        }
        #endregion
    }
}

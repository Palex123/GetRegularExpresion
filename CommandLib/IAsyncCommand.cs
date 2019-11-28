using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandLib
{
    public interface IAsyncCommand : ICommand
    {
        /// <summary>
        /// Introduce a wrapper as task to run the command in asynchronous mode
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        Task ExecuteAsync(object parameter);
    }
}

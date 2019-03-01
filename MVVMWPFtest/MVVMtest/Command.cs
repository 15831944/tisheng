using System;
using System.Windows.Input;


namespace MVVMtest
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (_canExcute!=null)
                {

                    CommandManager.RequerySuggested += value;
                }
            }
            remove
            {
            
                if (_canExcute != null)
                    {
                        CommandManager.RequerySuggested -= value;
                    }
            }
        }

        /// <summary>
        /// 判断是否可以执行的命令
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private Func<object, bool> _canExcute;
        /// <summary>
        /// 命令需要执行的方法
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private Action<object> _Excute;

        public Command(Action<object> execute):this(execute, null)
        {

        }
        /// <summary>
        /// 创建一个命令
        /// </summary>
        /// <param name="execute">命令要执行的方法</param>
        /// <param name="canExecute">判断命令是否能够执行的方法</param>
        /// <returns></returns>
        public Command(Action<object> execute, Func<object, bool> canExecute)
        {
            _canExcute = canExecute;
            _Excute = execute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExcute == null) return true;

            return _canExcute(parameter);
        }

        public void Execute(object parameter)
        {

            if (_Excute!=null&&CanExecute(parameter))
            {
                _Excute(parameter);
            }
        }
    }
}

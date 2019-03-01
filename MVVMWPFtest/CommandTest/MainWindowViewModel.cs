using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMtest;
using System.Windows;

namespace CommandTest
{
    class MainWindowViewModel : NotifyObject
    {
        private bool _canExcute;

        public bool CanExcute
        {
            get { return _canExcute; }
            set
            {
                if (_canExcute!=value)
                {
                    _canExcute = value;
                }
                RaisePropertyChanged("CanExcute");
            }
        }

        private Command _normalCommand;
        public Command NormalCommand
        {
            get
            {
                if (_normalCommand == null)
                    _normalCommand = new Command(
                        new Action<object>(
                            o => MessageBox.Show("这是个普通命令!")));
                return _normalCommand;


            }
        }
        private Command _CanExcuteCommand;
        public Command CanExcuteCommand
        {
            get
            {
                if (_CanExcuteCommand == null)
                    _CanExcuteCommand = new Command(
                        new Action<object>(
                            o => MessageBox.Show("命令可以执行！")),
                        new Func<object, bool>(
                            o => CanExcute));
                return _CanExcuteCommand;

            }
        }
        private Command _paramCommand;
        public Command ParamCommand
        {
            get
            {
                if (_paramCommand == null)
                    _paramCommand = new Command(
                        new Action<object>(
                            o => MessageBox.Show(o.ToString())),
                        new Func<object, bool>(
                            o => !string.IsNullOrEmpty(o.ToString())));
                return _paramCommand;
            }
        }



    }
}

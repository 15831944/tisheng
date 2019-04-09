using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryOfXA.Dal.Entities;
using RepositoryOfXA.Dal;
using System.Windows.Input;
using MVVMtest;

namespace RepositoryOfXA.ViewModels
{
   public class AddOrEditViewModel:ViewModelBase
    {
        private Operator _currentOperatorEntity;
        public Operator CurrentOperatorEntity
        {
            get { return _currentOperatorEntity; }
            set
            {
                if (_currentOperatorEntity != value)
                {
                    _currentOperatorEntity = value;
                    if (_currentOperatorEntity.Ope_Ifuse == 0)
                    {
                        IsChecked = true;
                    }
                    else
                    {
                        IsChecked = false;
                    }

                    this.OnPropertyChanged(() =>CurrentOperatorEntity);
                }
            }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    this.OnPropertyChanged(() =>IsChecked);
                }
            }
        }
        public OperatorDal OperatorDal { get; set; }

        private bool _isAdd = false;

        public bool IsAdd
        {
            get { return _isAdd; }
            set
            {
                if (_isAdd != value)
                {
                    _isAdd = value;
                    this.OnPropertyChanged(()=>IsAdd);
                }
            }
        }
        public ICommand SaveCommand { get; set; }

        public AddOrEditViewModel()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private void Save(object obj)
        {
            Operator Operator = new Operator();
            Operator.Ope_Name = CurrentOperatorEntity.Ope_Name;
            Operator.Ope_Account = CurrentOperatorEntity.Ope_Account;
            Operator.Ope_Ifuse = IsChecked ? 0 : 1;
            Operator.Ope_PassWord = CurrentOperatorEntity.Ope_PassWord;
            if (IsAdd)
            {
                OperatorDal.Insert(Operator);
            }
            else
            {
                Operator.Ope_Id = CurrentOperatorEntity.Ope_Id;
                OperatorDal.Update(Operator);
            }
        }
    }
}

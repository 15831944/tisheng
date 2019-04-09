using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RepositoryOfXA.Dal.Entities; 
using System.Threading.Tasks;
using System.Windows.Input;
using RepositoryOfXA.Dal;
using RepositoryOfXA.Views;

namespace RepositoryOfXA.ViewModels
{
    public class OperatorViewModel : ViewModelBase
    {
        private List<Operator> _operators;
        public List<Operator> Operator
        {
            get { return _operators; }
            set
            {
                if (_operators != value)
                {
                    _operators = value;
                    this.OnPropertyChanged(() => Operator);
                }
            }
        }
        private Operator _Operator;
        public Operator SelectOperatorEntity
        {
            get { return _Operator; }
            set
            {
                if (_Operator != value)
                {
                    _Operator = value;
                    this.OnPropertyChanged(() => SelectOperatorEntity);
                }
            }

        }
        public ICommand AddCommand { get; set; }
        public ICommand RefreshCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        private OperatorDal OperatorDal = null;
        public OperatorViewModel()
        {
            OperatorDal = new OperatorDal();
            AddCommand= new DelegateCommand(AddStuddent);
            RefreshCommand = new DelegateCommand(Refresh);
            EditCommand = new DelegateCommand(EditStudent);
            DeleteCommand = new DelegateCommand(DeleteStudent);
            Operator = new List<Operator> ();
            Operator = OperatorDal.GetAllUser();

        }
        
        private void AddStuddent(object obj)
        {
            AddOrEditWindow addOrEditWindow = new AddOrEditWindow();
            addOrEditWindow.Show();
            var addOrEditViewModel = (addOrEditWindow.DataContext as AddOrEditViewModel);
            addOrEditViewModel.CurrentOperatorEntity = new Operator();
            addOrEditViewModel.IsAdd = true;
            addOrEditViewModel.OperatorDal = OperatorDal;
        }

        private void Refresh(object obj)
        {
            Operator = OperatorDal.GetAllUser();
        }
        private void EditStudent(object obj)
        {
            AddOrEditWindow addOrEditWindow = new AddOrEditWindow();
            addOrEditWindow.Show();
            var addOrEditViewModel = (addOrEditWindow.DataContext as AddOrEditViewModel);
            addOrEditViewModel.CurrentOperatorEntity = SelectOperatorEntity;
            addOrEditViewModel.IsAdd = false;
            addOrEditViewModel.OperatorDal = OperatorDal;
        }

        private void DeleteStudent(object obj)
        {
            OperatorDal.Delete(SelectOperatorEntity);
        }




    }
}

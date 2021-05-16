using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMvvm.SimpleCalc
{
    public class FormViewModel : INotifyPropertyChanged
    {
        //private System.Windows.Forms.TextBox txtBxItem1;
        //private System.Windows.Forms.TextBox txtBxItem2;
        //private System.Windows.Forms.Label lblResult;
        //private System.Windows.Forms.Button btnRun;
        private string _txtItem1 = string.Empty;
        private string _txtItem2 = string.Empty;
        private string _txtResult = "0";
        public string txtItem1
        {
            get { return _txtItem1; }
            set
            {
                if (_txtItem1 == value) return;
                _txtItem1 = value;
                OnPropertyChanged("");
            }
        }
        public string txtItem2
        {
            get { return _txtItem2; }
            set
            {
                if (_txtItem2 == value) return;
                _txtItem2 = value;
                OnPropertyChanged("");
            }
        }
        public string txtResult
        {
            get { return _txtResult; }
            set
            {
                if (_txtResult == value) return;
                _txtResult = value;
                OnPropertyChanged("");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                // PropertyChangedEventArgs("") means that it notifies all property changed.  
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalcAct()
        {
            int tmp1 = int.Parse(txtItem1);
            int tmp2 = int.Parse(txtItem2);
            txtResult = Calc.Sum(tmp1, tmp2).ToString();
        }
    }
}

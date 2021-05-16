using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMvvm.SimpleCalc
{
    public partial class FormView : Form
    {
        private FormViewModel _viewModel = new FormViewModel();
        public FormView()
        {
            InitializeComponent();
            txtBxItem1.DataBindings.Add("Text", _viewModel, "txtItem1");
            txtBxItem2.DataBindings.Add("Text", _viewModel, "txtItem2");
            lblResult.DataBindings.Add("Text", _viewModel, "txtResult");
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            _viewModel.CalcAct();
        }
    }
}

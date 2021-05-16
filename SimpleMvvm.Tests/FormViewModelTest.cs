using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleMvvm.SimpleCalc;
using System;

namespace SimpleMvvm.Tests
{
    [TestClass]
    public class FormViewModelTest
    {
        [TestMethod]
        public void Senario()
        {
            var viewModel = new FormViewModel();
            // Check initial values
            Assert.AreEqual("", viewModel.txtItem1);
            Assert.AreEqual("", viewModel.txtItem2);
            Assert.AreEqual("0", viewModel.txtResult);

            // Check CalcAct()
            viewModel.txtItem1 = "14";
            viewModel.txtItem2 = "15";
            viewModel.CalcAct();
            Assert.AreEqual("29", viewModel.txtResult);

            viewModel.txtItem1 = "-5";
            viewModel.txtItem2 = "100";
            viewModel.CalcAct();
            Assert.AreEqual("95", viewModel.txtResult);

            viewModel.txtItem1 = "0";
            viewModel.txtItem2 = "-20";
            viewModel.CalcAct();
            Assert.AreEqual("-20", viewModel.txtResult);

            viewModel.txtItem1 = "9999";
            viewModel.txtItem2 = "1";
            viewModel.CalcAct();
            Assert.AreEqual("10000", viewModel.txtResult);
        }
    }
}

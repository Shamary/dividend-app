using FormApp1.Common;
using FormApp1.Controller;
using FormApp1.Model;
using FormApp1.Service;
using System;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class NewDividendForm : Form
    {
        private readonly ValidationController validationController= new ValidationController();
        private readonly DividendController dividendService = new DividendController();

        private readonly ViewDividendForm viewDividendForm;

        private string divId;

        public string DivId
        {
            get { return divId; }
            set { divId = value; }
        }


        public NewDividendForm(ViewDividendForm viewDividendForm)
        {
            InitializeComponent();
            this.viewDividendForm = viewDividendForm;
        }

        private void NewDividendForm_Load(object sender, EventArgs e)
        {
            string command = @"SELECT symbol_code, description FROM securities";

            symbolBindingSource.DataSource = dividendService.GetData(command);

            if (divId != null) // if divId is set then edit mode
            {
                this.Text = "Edit Dividend";
                Dividend dividend = dividendService.GetDividendById(divId);

                symbolSelect.SelectedValue = dividend.symbolCode;

                DateTime dateTime = new DateTime();
                DateTime.TryParse(dividend.paymentDate, out dateTime);

                paymentDatePicker.Value = dateTime;
            }
        }

        private void NewDividendForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.viewDividendForm.Show();
            divId = null;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Dividend dividend= new Dividend();
            dividend.symbolCode = symbolSelect.SelectedValue!=null ? symbolSelect.SelectedValue.ToString() : null;
            dividend.paymentDate = paymentDatePicker.Value.ToString(Constants.DATE_FORMAT);
            dividend.recordDate = DateTime.Now.ToString(Constants.DATE_FORMAT);
            dividend.statusId = (int)Constants.Status.PENDING;

            try
            {
                if (divId != null)
                {
                    dividend.divId = int.Parse(divId);
                    validationController.ValidateDividend(dividend, Constants.ValidationType.UPDATE);
                    dividendService.UpdateDividend(dividend);
                }
                else
                {
                    validationController.ValidateDividend(dividend);
                    dividendService.CreateDividend(dividend);
                }

                string successMsg = divId != null ? $"Dividend {dividend.symbolCode} successfully update" : $"Dividend {dividend.symbolCode} successfully added";
                DialogResult result = MessageBox.Show(successMsg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    this.viewDividendForm.Show();
                    this.viewDividendForm.ReloadTable();
                    divId = null;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

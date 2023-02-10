using FormApp1.Common;
using FormApp1.Controller;
using FormApp1.Exceptions;
using FormApp1.Service;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class ViewDividendForm : Form
    {
        private DividendController dividendService= new DividendController();
        ValidationController validationController= new ValidationController();

        private DataTable securityTable;
        private DataTable statusCodeTable;
        DataTable dataTable;


        private long dividendSize = 0;
        public ViewDividendForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddStatusColumn();
            LoadTable();
        }

        private void LoadDropDown()
        {
            string command = @"SELECT DISTINCT t1.symbol_code, t1.description FROM securities t1
                                JOIN
                                dividends t2 ON t1.symbol_code = t2.symbol_code";

            securityTable = dividendService.GetData(command, true);

            bindingSource2.DataSource = securityTable;

            command = @"SELECT DISTINCT t1.status_id, t1.status_name FROM status_codes t1
                                JOIN
                                dividends t2 ON t1.status_id = t2.status_id";
            statusCodeTable = dividendService.GetData(command, true);
            bindingSource3.DataSource = statusCodeTable;
        }

        private void AddStatusColumn()
        {
            dividendTable.Columns.Add("status", "Status");
            LoadMappedColumn();
        }

        private void LoadMappedColumn() // load the values for the Security and Status columns
        {
            LoadDropDown();
            for (int i = 0; i < dividendTable.Rows.Count; i++)
            {
                string symbolCode = dataTable.Select($"div_id='{dividendTable.Rows[i].Cells[0].Value}'")[0]["symbol_code"].ToString();
                string statusCode = dataTable.Select($"div_id='{dividendTable.Rows[i].Cells[0].Value}'")[0]["status_id"].ToString();
                
                dividendTable.Rows[i].Cells[1].Value = securityTable.Select($"symbol_code='{symbolCode}' OR description='{symbolCode}'")[0][1];

                dividendTable.Rows[i].Cells[3].Value = statusCodeTable.Select($"status_id={statusCode} OR status_name = '{statusCode}'")[0][1].ToString();
            }
        }

        private void AddActionColumn()
        {
            dividendTable.Columns.Add("action", "Actions");
            LoadActionColumn();
        }

        private void LoadActionColumn() // loads action links at each row
        {
            LoadDropDown();
            LoadMappedColumn();
            for (int i = 0; i < dividendTable.Rows.Count; i++)
            {
                int columnIndex = dividendTable.Rows[i].Cells["action"].ColumnIndex;

                MultiLink multiLink = new MultiLink();
                multiLink.DataGridViewObj = dividendTable;
                multiLink.ViewForm = this;
                multiLink.CurrentStatus =
                    (int)Enum.Parse(typeof(Constants.Status),
                    dividendTable.Rows[i].Cells["Status"].Value.ToString());// get int status value from enum using status name
                multiLink.Location = dividendTable.GetCellDisplayRectangle(columnIndex, i, true).Location;
                multiLink.ActiveCell = dividendTable.Rows[i].Cells[columnIndex];
                dividendTable.Controls.Add(multiLink);
            }
        }

        public void LoadTable() // gets dividend data for the display table
        {
            string command = @"SELECT div_id,symbol_code,payment_date,record_date,status_id FROM dividends";
            
            try
            {
                dataTable = dividendService.GetData(command);
                bindingSource1.DataSource = dataTable;

                dividendSize = dataTable.Rows.Count;

                RefreshActions();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e) // search button click handler
        {
            string where = "";
            string searchCommand = @"SELECT div_id,symbol_code,payment_date,record_date,status_id
                                    FROM dividends WHERE ";

            try
            {
                string startDate = startDatePicker.Value.ToString(Constants.DATE_FORMAT);
                string endDate = endDatePicker.Value.ToString(Constants.DATE_FORMAT);

                validationController.ValidateSearch(startDate, endDate);

                if (!symbolSelect.SelectedValue.ToString().Equals(Constants.DEFAULT_SELECT_ALL_INT.ToString()))
                {
                    where += $"symbol_code = '{symbolSelect.SelectedValue.ToString()}'";
                }

                where = AndWhere(where);

                where += $@"payment_date >= '{startDate}' 
                            AND payment_date <= '{endDate}'";

                if (statusSelect.SelectedValue != null && (int)statusSelect.SelectedValue >= 0)
                {
                    where = AndWhere(where);
                    where += $"status_id = {statusSelect.SelectedValue}";
                }

                searchCommand += where;

                DataTable dataTable = dividendService.GetData(searchCommand);
                bindingSource1.DataSource = dataTable;

                RefreshActions();
            }
            catch(ValidationFailedException  ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshActions() //updates the Actions Column
        {
            RemoveActions(Constants.COLUMN_ACTION);
            AddActionColumn();
        }

        public void ReloadTable()
        {
            LoadTable();
        }

        private void RemoveActions(string columnName)
        {
            if (columnName.Equals(Constants.COLUMN_ACTION))
            {
                RemoveControls();
            }

            if (dividendTable.Columns.Count > 4 && dividendTable.Columns[columnName] != null)
            {
                int columnIndex = dividendTable.Columns[columnName].Index;
                dividendTable.Columns.RemoveAt(columnIndex);
            }
        }

        private void RemoveControls()
        {
            for(int i = 0; i< dividendSize; i++)
            {
                dividendTable.Controls.Clear();
            }
        }

        private string AndWhere(string where) { 
            if (where.Count() > 0)
            {
                return where += " AND ";
            }

            return where;
        }

        private void NewLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // new link click handler
        {
            this.Hide();

            NewDividendForm newDividendForm = new NewDividendForm(this);

            newDividendForm.Show();
        }

        private void dividendTable_Sorted(object sender, EventArgs e)
        {
            RefreshActions(); // refresh action column on sort
        }
    }
}

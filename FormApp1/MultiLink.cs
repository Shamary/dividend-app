using FormApp1.Common;
using FormApp1.Service;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class MultiLink : UserControl
    {
        readonly DividendController dividendService = new DividendController();
        public MultiLink()
        {
            InitializeComponent();
        }

        #region
        private DataGridView _dataGridViewObj;

        [Category("Custom Props")]
        public DataGridView DataGridViewObj
        {
            get { return _dataGridViewObj; }
            set { _dataGridViewObj = value; }
        }

        private ViewDividendForm viewForm;

        public ViewDividendForm ViewForm
        {
            get { return viewForm; }
            set { viewForm = value; }
        }

        private int currentStatus;

        public int CurrentStatus
        {
            get { return currentStatus; }
            set { currentStatus = value; }
        }

        private DataGridViewCell activeCell;

        public DataGridViewCell ActiveCell
        {
            get { return activeCell; }
            set { activeCell = value; }
        }

        #endregion

        private void MultiLink_Load(object sender, EventArgs e)
        {
            SetVisibilityOnStatus();
        }

        // sets the active actions based on current dividend status
        private void SetVisibilityOnStatus()
        {
            switch(currentStatus)
            {
                case (int)Constants.Status.PENDING:
                    editLink.Show();
                    deleteLink.Show();
                    approveLink.Show();
                    cancelLink.Hide();
                    break;
                case (int)Constants.Status.ACTIVE:
                    editLink.Hide();
                    deleteLink.Hide();
                    approveLink.Hide();
                    cancelLink.Show();
                    break;
                default:
                    editLink.Hide();
                    deleteLink.Hide();
                    approveLink.Hide();
                    cancelLink.Hide();
                    break; 
            }
        }

        private void deleteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedRow();
            try
            {
                DataGridViewRow row = DataGridViewObj.CurrentCell.OwningRow;
                string id = row.Cells[0].Value.ToString();
                string security = row.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Do you want to delete {security}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) 
                {
                    dividendService.DeleteDividend(id);
                    viewForm.LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void editLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedRow();
            NewDividendForm newDividendForm = new NewDividendForm(this.ParentForm as ViewDividendForm);
            newDividendForm.DivId = this.DataGridViewObj.CurrentRow.Cells[0].Value.ToString();

            newDividendForm.Show();
            this.ParentForm.Hide();
        }

        private void approveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedRow();
            try
            {
                DataGridViewRow row = DataGridViewObj.CurrentRow;
                string id = row.Cells[0].Value.ToString();
                string security = row.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Do you want to approve dividend for {security}?", "Approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dividendService.UpdateState(id, Constants.Status.ACTIVE);
                    viewForm.LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedRow();
            try
            {
                DataGridViewRow row = DataGridViewObj.CurrentRow;
                string id = row.Cells[0].Value.ToString();
                string security = row.Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Do you want to cancel dividend for {security}?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dividendService.UpdateState(id, Constants.Status.CANCELLED);
                    ViewDividendForm viewDividendForm = new ViewDividendForm();
                    viewForm.LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectedRow()
        {
            DataGridViewObj.CurrentCell = ActiveCell;
        }
    }
}

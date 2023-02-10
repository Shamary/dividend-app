using FormApp1.Common;
using FormApp1.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FormApp1.Service
{
    internal class DividendController
    {
        private readonly string conn = System.Configuration.ConfigurationManager.ConnectionStrings["FormApp1.Properties.Settings.dividends_appConnectionString"].ConnectionString;

        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        public DataTable GetData(string command, bool select = false) // gets data from db
        {
            dataTable = new DataTable();

            sqlDataAdapter = new SqlDataAdapter(command, conn);
            sqlDataAdapter.Fill(dataTable);
            if (select) // adds All option to dropdowns
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = Constants.DEFAULT_SELECT_ALL_INT;
                dr[1] = Constants.DEFAULT_SELECT_ALL;

                dataTable.Rows.InsertAt(dr, 0);
            }

            return dataTable;
        }

        public Dividend GetDividendById(string id) // gets dividend using id
        {
            Dividend dividend = null;
            try
            {
                string command = $@"SELECT * FROM dividends WHERE div_id = {id}";
                sqlDataAdapter = new SqlDataAdapter(command, conn);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dividend = new Dividend();

                DataRow row = dataTable.Rows[0];

                dividend.divId = (int)row["div_id"];
                dividend.symbolCode = row["symbol_code"].ToString();
                dividend.paymentDate = row["payment_date"].ToString();
                dividend.recordDate = row["record_date"].ToString();
                dividend.statusId = (int)row["status_id"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dividend;
        }

        public void CreateDividend(Dividend dividend) // create dividend in db
        {
            string insert = $@"INSERT INTO dividends(symbol_code,payment_date,record_date,status_id) 
                            VALUES (@symbol_code,@payment_date,@record_date,@status_id)";

            SqlCommand sqlCommand;

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand(insert, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@symbol_code", dividend.symbolCode);
                sqlCommand.Parameters.AddWithValue("@payment_date", dividend.paymentDate);
                sqlCommand.Parameters.AddWithValue("@record_date", dividend.recordDate);
                sqlCommand.Parameters.AddWithValue("@status_id", dividend.statusId);

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void UpdateDividend(Dividend dividend) // update dividend in db
        {
            string update = $@"UPDATE dividends SET symbol_code =@SymbolCode,
                               payment_date=@PaymentDate,
                               record_date=@RecordDate
                               WHERE div_id =@DivId";


            SqlCommand sqlCommand;

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(update, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@SymbolCode", dividend.symbolCode);
                sqlCommand.Parameters.AddWithValue("@PaymentDate", dividend.paymentDate);
                sqlCommand.Parameters.AddWithValue("@RecordDate", dividend.recordDate);
                sqlCommand.Parameters.AddWithValue("@DivId", dividend.divId);

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void DeleteDividend(string id) // deletes dividend from db
        {
            string delete = $@"DELETE FROM dividends WHERE div_id = @DivId";

            using (SqlConnection sqlConnection = new SqlConnection(conn)) { 
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(delete, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DivId", id);
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void UpdateState(string id, Constants.Status status) // updates dividend status
        {
            string approve = $@"UPDATE dividends SET status_id = @StatusId
                                WHERE div_id = @DivId";

            using (SqlConnection sqlConnection = new SqlConnection(conn))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(approve, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@DivId", id);
                sqlCommand.Parameters.AddWithValue("@StatusId", status);
                sqlCommand.ExecuteNonQuery();
            }

        }
    }
}

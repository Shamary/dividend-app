namespace FormApp1
{
    partial class ViewDividendForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dividendTable = new System.Windows.Forms.DataGridView();
            this.dividDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolSrchLabel = new System.Windows.Forms.Label();
            this.symbolSelect = new System.Windows.Forms.ComboBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.statusSelect = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.newLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(FormApp1.dividend);
            // 
            // dividendTable
            // 
            this.dividendTable.AllowUserToAddRows = false;
            this.dividendTable.AllowUserToDeleteRows = false;
            this.dividendTable.AutoGenerateColumns = false;
            this.dividendTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dividendTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dividendTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dividDataGridViewTextBoxColumn,
            this.symbolcodeDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn});
            this.dividendTable.DataSource = this.bindingSource1;
            this.dividendTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dividendTable.Location = new System.Drawing.Point(0, 128);
            this.dividendTable.Name = "dividendTable";
            this.dividendTable.ReadOnly = true;
            this.dividendTable.RowHeadersWidth = 51;
            this.dividendTable.RowTemplate.Height = 24;
            this.dividendTable.Size = new System.Drawing.Size(1140, 398);
            this.dividendTable.TabIndex = 0;
            this.dividendTable.Sorted += new System.EventHandler(this.dividendTable_Sorted);
            // 
            // dividDataGridViewTextBoxColumn
            // 
            this.dividDataGridViewTextBoxColumn.DataPropertyName = "div_id";
            this.dividDataGridViewTextBoxColumn.HeaderText = "ID";
            this.dividDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dividDataGridViewTextBoxColumn.Name = "dividDataGridViewTextBoxColumn";
            this.dividDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symbolcodeDataGridViewTextBoxColumn
            // 
            this.symbolcodeDataGridViewTextBoxColumn.DataPropertyName = "symbol_code";
            this.symbolcodeDataGridViewTextBoxColumn.HeaderText = "Security";
            this.symbolcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.symbolcodeDataGridViewTextBoxColumn.Name = "symbolcodeDataGridViewTextBoxColumn";
            this.symbolcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "payment_date";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.paymentdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // symbolSrchLabel
            // 
            this.symbolSrchLabel.AutoSize = true;
            this.symbolSrchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolSrchLabel.Location = new System.Drawing.Point(33, 17);
            this.symbolSrchLabel.Name = "symbolSrchLabel";
            this.symbolSrchLabel.Size = new System.Drawing.Size(59, 16);
            this.symbolSrchLabel.TabIndex = 2;
            this.symbolSrchLabel.Text = "Symbol";
            // 
            // symbolSelect
            // 
            this.symbolSelect.DataSource = this.bindingSource2;
            this.symbolSelect.DisplayMember = "description";
            this.symbolSelect.FormattingEnabled = true;
            this.symbolSelect.Location = new System.Drawing.Point(12, 47);
            this.symbolSelect.Name = "symbolSelect";
            this.symbolSelect.Size = new System.Drawing.Size(200, 24);
            this.symbolSelect.TabIndex = 4;
            this.symbolSelect.ValueMember = "symbol_code";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = typeof(FormApp1.security);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.Location = new System.Drawing.Point(319, 17);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(76, 16);
            this.startDateLabel.TabIndex = 5;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.Location = new System.Drawing.Point(617, 17);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(71, 16);
            this.endDateLabel.TabIndex = 6;
            this.endDateLabel.Text = "End Date";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(879, 17);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 16);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(288, 49);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 8;
            this.startDatePicker.Value = new System.DateTime(2023, 2, 5, 0, 0, 0, 0);
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(570, 49);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 9;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataSource = typeof(FormApp1.status_code);
            // 
            // statusSelect
            // 
            this.statusSelect.DataSource = this.bindingSource3;
            this.statusSelect.DisplayMember = "status_name";
            this.statusSelect.FormattingEnabled = true;
            this.statusSelect.Location = new System.Drawing.Point(852, 47);
            this.statusSelect.Name = "statusSelect";
            this.statusSelect.Size = new System.Drawing.Size(121, 24);
            this.statusSelect.TabIndex = 10;
            this.statusSelect.ValueMember = "status_id";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1034, 47);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newLabel.Location = new System.Drawing.Point(1077, 100);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(51, 25);
            this.newLabel.TabIndex = 12;
            this.newLabel.TabStop = true;
            this.newLabel.Text = "New";
            this.newLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewLabel_LinkClicked);
            // 
            // ViewDividendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 526);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.statusSelect);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.symbolSelect);
            this.Controls.Add(this.symbolSrchLabel);
            this.Controls.Add(this.dividendTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ViewDividendForm";
            this.Text = "View Dividend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dividendTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dividendTable;
        private System.Windows.Forms.Label symbolSrchLabel;
        private System.Windows.Forms.ComboBox symbolSelect;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.ComboBox statusSelect;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.LinkLabel newLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dividDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
    }
}


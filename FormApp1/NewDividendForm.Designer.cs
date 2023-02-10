namespace FormApp1
{
    partial class NewDividendForm
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
            this.symbolLabel = new System.Windows.Forms.Label();
            this.symbolSelect = new System.Windows.Forms.ComboBox();
            this.symbolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.symbolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.symbolLabel.Location = new System.Drawing.Point(12, 55);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(84, 25);
            this.symbolLabel.TabIndex = 0;
            this.symbolLabel.Text = "Symbol";
            // 
            // symbolSelect
            // 
            this.symbolSelect.DataSource = this.symbolBindingSource;
            this.symbolSelect.DisplayMember = "description";
            this.symbolSelect.FormattingEnabled = true;
            this.symbolSelect.Location = new System.Drawing.Point(213, 56);
            this.symbolSelect.Name = "symbolSelect";
            this.symbolSelect.Size = new System.Drawing.Size(215, 24);
            this.symbolSelect.TabIndex = 1;
            this.symbolSelect.ValueMember = "symbol_code";
            // 
            // symbolBindingSource
            // 
            this.symbolBindingSource.DataSource = typeof(FormApp1.security);
            // 
            // paymentDatePicker
            // 
            this.paymentDatePicker.Location = new System.Drawing.Point(213, 153);
            this.paymentDatePicker.Name = "paymentDatePicker";
            this.paymentDatePicker.Size = new System.Drawing.Size(215, 22);
            this.paymentDatePicker.TabIndex = 10;
            this.paymentDatePicker.Value = new System.DateTime(2023, 2, 5, 0, 0, 0, 0);
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.paymentDateLabel.Location = new System.Drawing.Point(12, 150);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(147, 25);
            this.paymentDateLabel.TabIndex = 9;
            this.paymentDateLabel.Text = "Payment Date";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.submitBtn.Location = new System.Drawing.Point(213, 308);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(215, 55);
            this.submitBtn.TabIndex = 11;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // NewDividendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.paymentDatePicker);
            this.Controls.Add(this.paymentDateLabel);
            this.Controls.Add(this.symbolSelect);
            this.Controls.Add(this.symbolLabel);
            this.Name = "NewDividendForm";
            this.Text = "New Dividend";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDividendForm_FormClosed);
            this.Load += new System.EventHandler(this.NewDividendForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symbolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.ComboBox symbolSelect;
        private System.Windows.Forms.BindingSource symbolBindingSource;
        private System.Windows.Forms.DateTimePicker paymentDatePicker;
        private System.Windows.Forms.Label paymentDateLabel;
        private System.Windows.Forms.Button submitBtn;
    }
}
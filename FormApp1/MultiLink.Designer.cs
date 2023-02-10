namespace FormApp1
{
    partial class MultiLink
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.editLink = new System.Windows.Forms.LinkLabel();
            this.approveLink = new System.Windows.Forms.LinkLabel();
            this.cancelLink = new System.Windows.Forms.LinkLabel();
            this.deleteLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // editLink
            // 
            this.editLink.AutoSize = true;
            this.editLink.Location = new System.Drawing.Point(-1, 5);
            this.editLink.Name = "editLink";
            this.editLink.Size = new System.Drawing.Size(30, 16);
            this.editLink.TabIndex = 0;
            this.editLink.TabStop = true;
            this.editLink.Text = "Edit";
            this.editLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editLink_LinkClicked);
            // 
            // approveLink
            // 
            this.approveLink.AutoSize = true;
            this.approveLink.Location = new System.Drawing.Point(30, 5);
            this.approveLink.Name = "approveLink";
            this.approveLink.Size = new System.Drawing.Size(59, 16);
            this.approveLink.TabIndex = 1;
            this.approveLink.TabStop = true;
            this.approveLink.Text = "Approve";
            this.approveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.approveLink_LinkClicked);
            // 
            // cancelLink
            // 
            this.cancelLink.AutoSize = true;
            this.cancelLink.Location = new System.Drawing.Point(91, 5);
            this.cancelLink.Name = "cancelLink";
            this.cancelLink.Size = new System.Drawing.Size(49, 16);
            this.cancelLink.TabIndex = 2;
            this.cancelLink.TabStop = true;
            this.cancelLink.Text = "Cancel";
            this.cancelLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cancelLink_LinkClicked);
            // 
            // deleteLink
            // 
            this.deleteLink.AutoSize = true;
            this.deleteLink.Location = new System.Drawing.Point(139, 5);
            this.deleteLink.Name = "deleteLink";
            this.deleteLink.Size = new System.Drawing.Size(47, 16);
            this.deleteLink.TabIndex = 3;
            this.deleteLink.TabStop = true;
            this.deleteLink.Text = "Delete";
            this.deleteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deleteLink_LinkClicked);
            // 
            // MultiLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteLink);
            this.Controls.Add(this.cancelLink);
            this.Controls.Add(this.approveLink);
            this.Controls.Add(this.editLink);
            this.Name = "MultiLink";
            this.Size = new System.Drawing.Size(194, 27);
            this.Load += new System.EventHandler(this.MultiLink_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel editLink;
        private System.Windows.Forms.LinkLabel approveLink;
        private System.Windows.Forms.LinkLabel cancelLink;
        private System.Windows.Forms.LinkLabel deleteLink;
    }
}

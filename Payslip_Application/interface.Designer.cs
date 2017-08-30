namespace Payslip_Application
{
    partial class Form1
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
            this.lblListHeading = new System.Windows.Forms.Label();
            this.listbox_items = new System.Windows.Forms.ListBox();
            this.btn_calcAllPay = new System.Windows.Forms.Button();
            this.lbl_calcAllPay = new System.Windows.Forms.Label();
            this.pnl_update = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtbox_parameter2 = new System.Windows.Forms.TextBox();
            this.lbl_parameter2 = new System.Windows.Forms.Label();
            this.txtbox_parameter1 = new System.Windows.Forms.TextBox();
            this.lbl_parameter1 = new System.Windows.Forms.Label();
            this.lbl_personnelData = new System.Windows.Forms.Label();
            this.btn_closeProgram = new System.Windows.Forms.Button();
            this.pnl_update.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListHeading
            // 
            this.lblListHeading.AutoSize = true;
            this.lblListHeading.Location = new System.Drawing.Point(15, 11);
            this.lblListHeading.Name = "lblListHeading";
            this.lblListHeading.Size = new System.Drawing.Size(47, 11);
            this.lblListHeading.TabIndex = 0;
            this.lblListHeading.Text = "label1";
            // 
            // listbox_items
            // 
            this.listbox_items.FormattingEnabled = true;
            this.listbox_items.ItemHeight = 11;
            this.listbox_items.Location = new System.Drawing.Point(17, 25);
            this.listbox_items.Name = "listbox_items";
            this.listbox_items.Size = new System.Drawing.Size(1201, 356);
            this.listbox_items.TabIndex = 1;
            this.listbox_items.SelectedIndexChanged += new System.EventHandler(this.listbox_items_SelectedIndexChanged);
            // 
            // btn_calcAllPay
            // 
            this.btn_calcAllPay.Location = new System.Drawing.Point(17, 387);
            this.btn_calcAllPay.Name = "btn_calcAllPay";
            this.btn_calcAllPay.Size = new System.Drawing.Size(130, 50);
            this.btn_calcAllPay.TabIndex = 2;
            this.btn_calcAllPay.Text = "Calculate pay and payslip details";
            this.btn_calcAllPay.UseVisualStyleBackColor = true;
            this.btn_calcAllPay.Click += new System.EventHandler(this.btn_calcAllPay_Click);
            // 
            // lbl_calcAllPay
            // 
            this.lbl_calcAllPay.AutoSize = true;
            this.lbl_calcAllPay.Location = new System.Drawing.Point(15, 440);
            this.lbl_calcAllPay.Name = "lbl_calcAllPay";
            this.lbl_calcAllPay.Size = new System.Drawing.Size(68, 11);
            this.lbl_calcAllPay.TabIndex = 3;
            this.lbl_calcAllPay.Text = "Total pay";
            // 
            // pnl_update
            // 
            this.pnl_update.Controls.Add(this.btn_cancel);
            this.pnl_update.Controls.Add(this.btn_update);
            this.pnl_update.Controls.Add(this.txtbox_parameter2);
            this.pnl_update.Controls.Add(this.lbl_parameter2);
            this.pnl_update.Controls.Add(this.txtbox_parameter1);
            this.pnl_update.Controls.Add(this.lbl_parameter1);
            this.pnl_update.Controls.Add(this.lbl_personnelData);
            this.pnl_update.Location = new System.Drawing.Point(264, 387);
            this.pnl_update.Name = "pnl_update";
            this.pnl_update.Size = new System.Drawing.Size(566, 162);
            this.pnl_update.TabIndex = 4;
            this.pnl_update.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(109, 136);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(3, 136);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 23);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtbox_parameter2
            // 
            this.txtbox_parameter2.Location = new System.Drawing.Point(237, 81);
            this.txtbox_parameter2.Name = "txtbox_parameter2";
            this.txtbox_parameter2.Size = new System.Drawing.Size(100, 18);
            this.txtbox_parameter2.TabIndex = 4;
            // 
            // lbl_parameter2
            // 
            this.lbl_parameter2.AutoSize = true;
            this.lbl_parameter2.Location = new System.Drawing.Point(3, 84);
            this.lbl_parameter2.Name = "lbl_parameter2";
            this.lbl_parameter2.Size = new System.Drawing.Size(89, 11);
            this.lbl_parameter2.TabIndex = 3;
            this.lbl_parameter2.Text = "Parameter 2:";
            // 
            // txtbox_parameter1
            // 
            this.txtbox_parameter1.Location = new System.Drawing.Point(237, 50);
            this.txtbox_parameter1.Name = "txtbox_parameter1";
            this.txtbox_parameter1.Size = new System.Drawing.Size(100, 18);
            this.txtbox_parameter1.TabIndex = 2;
            // 
            // lbl_parameter1
            // 
            this.lbl_parameter1.AutoSize = true;
            this.lbl_parameter1.Location = new System.Drawing.Point(3, 53);
            this.lbl_parameter1.Name = "lbl_parameter1";
            this.lbl_parameter1.Size = new System.Drawing.Size(89, 11);
            this.lbl_parameter1.TabIndex = 1;
            this.lbl_parameter1.Text = "Parameter 1:";
            // 
            // lbl_personnelData
            // 
            this.lbl_personnelData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_personnelData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_personnelData.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personnelData.Location = new System.Drawing.Point(2, 0);
            this.lbl_personnelData.Name = "lbl_personnelData";
            this.lbl_personnelData.Size = new System.Drawing.Size(566, 19);
            this.lbl_personnelData.TabIndex = 0;
            this.lbl_personnelData.Text = "Personnel Data";
            // 
            // btn_closeProgram
            // 
            this.btn_closeProgram.Location = new System.Drawing.Point(17, 503);
            this.btn_closeProgram.Name = "btn_closeProgram";
            this.btn_closeProgram.Size = new System.Drawing.Size(66, 43);
            this.btn_closeProgram.TabIndex = 5;
            this.btn_closeProgram.Text = "Close program";
            this.btn_closeProgram.UseVisualStyleBackColor = true;
            this.btn_closeProgram.Click += new System.EventHandler(this.btn_closeProgram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 561);
            this.Controls.Add(this.btn_closeProgram);
            this.Controls.Add(this.pnl_update);
            this.Controls.Add(this.lbl_calcAllPay);
            this.Controls.Add(this.btn_calcAllPay);
            this.Controls.Add(this.listbox_items);
            this.Controls.Add(this.lblListHeading);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payslip Application";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_update.ResumeLayout(false);
            this.pnl_update.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListHeading;
        private System.Windows.Forms.ListBox listbox_items;
        private System.Windows.Forms.Button btn_calcAllPay;
        private System.Windows.Forms.Label lbl_calcAllPay;
        private System.Windows.Forms.Panel pnl_update;
        private System.Windows.Forms.Label lbl_personnelData;
        private System.Windows.Forms.TextBox txtbox_parameter1;
        private System.Windows.Forms.Label lbl_parameter1;
        private System.Windows.Forms.Label lbl_parameter2;
        private System.Windows.Forms.TextBox txtbox_parameter2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_closeProgram;
    }
}


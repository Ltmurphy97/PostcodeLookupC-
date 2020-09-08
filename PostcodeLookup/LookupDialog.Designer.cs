namespace PostcodeLookup
{
    partial class LookupDialog
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
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblRawSearch = new System.Windows.Forms.Label();
            this.lbValidOptions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRelevant = new System.Windows.Forms.Label();
            this.linkMap = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtPostcode
            // 
            this.txtPostcode.BackColor = System.Drawing.Color.White;
            this.txtPostcode.Location = new System.Drawing.Point(121, 84);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(179, 20);
            this.txtPostcode.TabIndex = 0;
            this.txtPostcode.TextChanged += new System.EventHandler(this.txtPostcode_TextChanged);
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(60, 87);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 2;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblRawSearch
            // 
            this.lblRawSearch.AutoSize = true;
            this.lblRawSearch.Location = new System.Drawing.Point(60, 120);
            this.lblRawSearch.Name = "lblRawSearch";
            this.lblRawSearch.Size = new System.Drawing.Size(94, 13);
            this.lblRawSearch.TabIndex = 3;
            this.lblRawSearch.Text = "You searched for: ";
            // 
            // lbValidOptions
            // 
            this.lbValidOptions.BackColor = System.Drawing.Color.White;
            this.lbValidOptions.FormattingEnabled = true;
            this.lbValidOptions.Location = new System.Drawing.Point(63, 166);
            this.lbValidOptions.Name = "lbValidOptions";
            this.lbValidOptions.Size = new System.Drawing.Size(427, 212);
            this.lbValidOptions.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Postcode Lookup Tool";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(240, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Luke Murphy";
            // 
            // lblRelevant
            // 
            this.lblRelevant.AutoSize = true;
            this.lblRelevant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelevant.Location = new System.Drawing.Point(60, 150);
            this.lblRelevant.Name = "lblRelevant";
            this.lblRelevant.Size = new System.Drawing.Size(130, 13);
            this.lblRelevant.TabIndex = 10;
            this.lblRelevant.Text = "Available Delivery Options";
            this.lblRelevant.Click += new System.EventHandler(this.lblRelevant_Click);
            // 
            // linkMap
            // 
            this.linkMap.AutoSize = true;
            this.linkMap.Location = new System.Drawing.Point(307, 90);
            this.linkMap.Name = "linkMap";
            this.linkMap.Size = new System.Drawing.Size(69, 13);
            this.linkMap.TabIndex = 11;
            this.linkMap.TabStop = true;
            this.linkMap.Text = "View on Map";
            this.linkMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMap_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 438);
            this.Controls.Add(this.linkMap);
            this.Controls.Add(this.lblRelevant);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbValidOptions);
            this.Controls.Add(this.lblRawSearch);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.txtPostcode);
            this.Name = "Form1";
            this.Text = "Postcode Lookup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblRawSearch;
        private System.Windows.Forms.ListBox lbValidOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRelevant;
        private System.Windows.Forms.LinkLabel linkMap;
    }
}


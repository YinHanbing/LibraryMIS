namespace LibraryMIS
{
    partial class FormUserInsert
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
            this.edtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpParameters = new System.Windows.Forms.GroupBox();
            this.edtUserName = new System.Windows.Forms.TextBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(90, 70);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(137, 21);
            this.edtName.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(42, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "姓名";
            // 
            // grpParameters
            // 
            this.grpParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpParameters.Controls.Add(this.edtName);
            this.grpParameters.Controls.Add(this.label4);
            this.grpParameters.Controls.Add(this.edtUserName);
            this.grpParameters.Controls.Add(this.lblServerName);
            this.grpParameters.ForeColor = System.Drawing.Color.Teal;
            this.grpParameters.Location = new System.Drawing.Point(21, 32);
            this.grpParameters.Name = "grpParameters";
            this.grpParameters.Size = new System.Drawing.Size(238, 124);
            this.grpParameters.TabIndex = 11;
            this.grpParameters.TabStop = false;
            // 
            // edtUserName
            // 
            this.edtUserName.Location = new System.Drawing.Point(90, 31);
            this.edtUserName.Name = "edtUserName";
            this.edtUserName.Size = new System.Drawing.Size(137, 21);
            this.edtUserName.TabIndex = 4;
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerName.Location = new System.Drawing.Point(30, 32);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(41, 12);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "用户名";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(62, 181);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(143, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormUserInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 227);
            this.Controls.Add(this.grpParameters);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormUserInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加用户";
            this.Load += new System.EventHandler(this.FormUserInsert_Load);
            this.grpParameters.ResumeLayout(false);
            this.grpParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpParameters;
        private System.Windows.Forms.TextBox edtUserName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}
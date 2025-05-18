namespace project_1
{
    partial class F_LOGIN
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
            this.L_Name = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.L_UserType = new System.Windows.Forms.Label();
            this.CB_UserType = new System.Windows.Forms.ComboBox();
            this.B_LogIN = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_SingUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.BackColor = System.Drawing.Color.Transparent;
            this.L_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name.ForeColor = System.Drawing.SystemColors.MenuText;
            this.L_Name.Location = new System.Drawing.Point(70, 68);
            this.L_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(63, 20);
            this.L_Name.TabIndex = 0;
            this.L_Name.Text = "EMAIL";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.BackColor = System.Drawing.Color.Transparent;
            this.L_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.L_Password.Location = new System.Drawing.Point(70, 131);
            this.L_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(111, 20);
            this.L_Password.TabIndex = 1;
            this.L_Password.Text = "PASSWORD";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(74, 101);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(176, 20);
            this.TB_Email.TabIndex = 2;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(74, 166);
            this.TB_Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(176, 20);
            this.TB_Password.TabIndex = 3;
            this.TB_Password.UseSystemPasswordChar = true;
            // 
            // L_UserType
            // 
            this.L_UserType.AutoSize = true;
            this.L_UserType.BackColor = System.Drawing.Color.Transparent;
            this.L_UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.L_UserType.Location = new System.Drawing.Point(70, 198);
            this.L_UserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.L_UserType.Name = "L_UserType";
            this.L_UserType.Size = new System.Drawing.Size(109, 20);
            this.L_UserType.TabIndex = 4;
            this.L_UserType.Text = "USER TYPE";
            // 
            // CB_UserType
            // 
            this.CB_UserType.FormattingEnabled = true;
            this.CB_UserType.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.CB_UserType.Location = new System.Drawing.Point(74, 233);
            this.CB_UserType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_UserType.Name = "CB_UserType";
            this.CB_UserType.Size = new System.Drawing.Size(176, 21);
            this.CB_UserType.TabIndex = 5;
            // 
            // B_LogIN
            // 
            this.B_LogIN.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_LogIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_LogIN.ForeColor = System.Drawing.SystemColors.MenuText;
            this.B_LogIN.Location = new System.Drawing.Point(74, 287);
            this.B_LogIN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_LogIN.Name = "B_LogIN";
            this.B_LogIN.Size = new System.Drawing.Size(176, 46);
            this.B_LogIN.TabIndex = 6;
            this.B_LogIN.Text = "LOG IN";
            this.B_LogIN.UseVisualStyleBackColor = false;
            this.B_LogIN.Click += new System.EventHandler(this.B_LogIN_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Exit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.B_Exit.Location = new System.Drawing.Point(74, 418);
            this.B_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(176, 46);
            this.B_Exit.TabIndex = 7;
            this.B_Exit.Text = "EXIT";
            this.B_Exit.UseVisualStyleBackColor = false;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(79, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome";
            // 
            // B_SingUP
            // 
            this.B_SingUP.BackColor = System.Drawing.SystemColors.Highlight;
            this.B_SingUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_SingUP.ForeColor = System.Drawing.SystemColors.MenuText;
            this.B_SingUP.Location = new System.Drawing.Point(74, 351);
            this.B_SingUP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_SingUP.Name = "B_SingUP";
            this.B_SingUP.Size = new System.Drawing.Size(176, 46);
            this.B_SingUP.TabIndex = 9;
            this.B_SingUP.Text = "SING UP";
            this.B_SingUP.UseVisualStyleBackColor = false;
            this.B_SingUP.Click += new System.EventHandler(this.B_SingUP_Click);
            // 
            // F_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(326, 499);
            this.Controls.Add(this.B_SingUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Exit);
            this.Controls.Add(this.B_LogIN);
            this.Controls.Add(this.CB_UserType);
            this.Controls.Add(this.L_UserType);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Name);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.F_LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_UserType;
        private System.Windows.Forms.ComboBox CB_UserType;
        private System.Windows.Forms.Button B_LogIN;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_SingUP;
    }
}


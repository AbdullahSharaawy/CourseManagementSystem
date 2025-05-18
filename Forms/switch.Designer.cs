namespace project_1
{
    partial class @switch
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
            this.CB_TEACHER = new System.Windows.Forms.CheckBox();
            this.CB_STUDENT = new System.Windows.Forms.CheckBox();
            this.B_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_TEACHER
            // 
            this.CB_TEACHER.AutoSize = true;
            this.CB_TEACHER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_TEACHER.Location = new System.Drawing.Point(25, 76);
            this.CB_TEACHER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_TEACHER.Name = "CB_TEACHER";
            this.CB_TEACHER.Size = new System.Drawing.Size(106, 24);
            this.CB_TEACHER.TabIndex = 0;
            this.CB_TEACHER.Text = "Instructor";
            this.CB_TEACHER.UseVisualStyleBackColor = true;
            // 
            // CB_STUDENT
            // 
            this.CB_STUDENT.AutoSize = true;
            this.CB_STUDENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_STUDENT.Location = new System.Drawing.Point(188, 76);
            this.CB_STUDENT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CB_STUDENT.Name = "CB_STUDENT";
            this.CB_STUDENT.Size = new System.Drawing.Size(92, 24);
            this.CB_STUDENT.TabIndex = 1;
            this.CB_STUDENT.Text = "Student";
            this.CB_STUDENT.UseVisualStyleBackColor = true;
            // 
            // B_Enter
            // 
            this.B_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Enter.Location = new System.Drawing.Point(110, 142);
            this.B_Enter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.B_Enter.Name = "B_Enter";
            this.B_Enter.Size = new System.Drawing.Size(84, 46);
            this.B_Enter.TabIndex = 2;
            this.B_Enter.Text = "Enter";
            this.B_Enter.UseVisualStyleBackColor = true;
            this.B_Enter.Click += new System.EventHandler(this.B_Enter_Click);
            // 
            // @switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(312, 214);
            this.Controls.Add(this.B_Enter);
            this.Controls.Add(this.CB_STUDENT);
            this.Controls.Add(this.CB_TEACHER);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "@switch";
            this.Text = "@switch";
            this.Load += new System.EventHandler(this.switch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_TEACHER;
        private System.Windows.Forms.CheckBox CB_STUDENT;
        private System.Windows.Forms.Button B_Enter;
    }
}
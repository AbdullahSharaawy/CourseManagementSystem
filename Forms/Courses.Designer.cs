﻿namespace project_1
{
    partial class Courses
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
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filter1 = new DVLD.Filter();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCourses
            // 
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Location = new System.Drawing.Point(2, 224);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.Size = new System.Drawing.Size(928, 227);
            this.dgCourses.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Courses";
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(12, 181);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(375, 37);
            this.filter1.TabIndex = 1;
            this.filter1.evFilterResult += new System.EventHandler<System.Data.DataTable>(this.filter1_evFilterResult);
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(935, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.dgCourses);
            this.Name = "Courses";
            this.Text = "da";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCourses;
        private DVLD.Filter filter1;
        private System.Windows.Forms.Label label1;
    }
}
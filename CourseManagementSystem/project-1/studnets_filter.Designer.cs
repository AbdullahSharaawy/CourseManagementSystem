namespace project_1
{
    partial class studnets_filter
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.filter1 = new DVLD.Filter();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Students";
            // 
            // dgStudents
            // 
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Location = new System.Drawing.Point(2, 245);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.Size = new System.Drawing.Size(928, 227);
            this.dgStudents.TabIndex = 3;
            // 
            // filter1
            // 
            this.filter1.Location = new System.Drawing.Point(12, 202);
            this.filter1.Name = "filter1";
            this.filter1.Size = new System.Drawing.Size(375, 37);
            this.filter1.TabIndex = 6;
            this.filter1.evFilterResult += new System.EventHandler<System.Data.DataTable>(this.filter1_evFilterResult);
            // 
            // studnets_filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(931, 472);
            this.Controls.Add(this.filter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgStudents);
            this.Name = "studnets_filter";
            this.Text = "studnets_filter";
            this.Load += new System.EventHandler(this.studnets_filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgStudents;
        private DVLD.Filter filter1;
    }
}
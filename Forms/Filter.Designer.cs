namespace DVLD
{
    partial class Filter
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
            this.tbSelectorItem = new System.Windows.Forms.TextBox();
            this.cbFilterItems = new System.Windows.Forms.ComboBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSelectorItem
            // 
            this.tbSelectorItem.Location = new System.Drawing.Point(222, 9);
            this.tbSelectorItem.Name = "tbSelectorItem";
            this.tbSelectorItem.Size = new System.Drawing.Size(139, 20);
            this.tbSelectorItem.TabIndex = 11;
            this.tbSelectorItem.Visible = false;
            this.tbSelectorItem.TextChanged += new System.EventHandler(this.tbSelectorItem_TextChanged);
            // 
            // cbFilterItems
            // 
            this.cbFilterItems.FormattingEnabled = true;
            this.cbFilterItems.Location = new System.Drawing.Point(81, 9);
            this.cbFilterItems.Name = "cbFilterItems";
            this.cbFilterItems.Size = new System.Drawing.Size(121, 21);
            this.cbFilterItems.TabIndex = 9;
            this.cbFilterItems.SelectedIndexChanged += new System.EventHandler(this.cbFilterItems_SelectedIndexChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.BackColor = System.Drawing.Color.White;
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(2, 9);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(73, 20);
            this.lbFilter.TabIndex = 10;
            this.lbFilter.Text = "Filter by";
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSelectorItem);
            this.Controls.Add(this.cbFilterItems);
            this.Controls.Add(this.lbFilter);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(375, 37);
            this.Load += new System.EventHandler(this.Filter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSelectorItem;
        private System.Windows.Forms.ComboBox cbFilterItems;
        private System.Windows.Forms.Label lbFilter;
    }
}

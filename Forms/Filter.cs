using project_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class Filter : UserControl
    {
        public static DataTable _AllData;// all data
        private DataTable _FilterResult;// result of filter
        public event EventHandler<DataTable> evFilterResult;
        public static string[] ComboItems;
        public Filter()
        {
            InitializeComponent();
            cbFilterItems.DropDownStyle=ComboBoxStyle.DropDownList;
            Courses.evFillComboBox += FillFilterComboBox;
            studnets_filter.evFillComboBox += FillFilterComboBox;
        }
        private   void FillFilterComboBox()
        {
            cbFilterItems.Items.Clear();
            cbFilterItems.Items.AddRange(ComboItems);
        }
        private void cbFilterItems_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (cbFilterItems.SelectedIndex > 0)
            {
                FilterProcess();
                tbSelectorItem.Visible = true;
            }
            else
            {
                _FilterResult = _AllData;
                evFilterResult?.Invoke(this, _FilterResult);
                tbSelectorItem.Visible = false;
                tbSelectorItem.Text = "";
            }
        }
        private void tbSelectorItem_TextChanged(object sender, EventArgs e)
        {
            FilterProcess();
        }
        private void FilterProcess()
        {
            if (cbFilterItems.SelectedIndex > 0 && (tbSelectorItem.Text != null && tbSelectorItem.Text != ""))
            {
                try
                {
                    DataView view = new DataView(_AllData);
                    string FilterType = cbFilterItems.SelectedItem.ToString().Replace(" ", "");
                    view.RowFilter = $"{FilterType}='{tbSelectorItem.Text}'";
                    _FilterResult = view.ToTable();

                }
                catch { }
            }
            else
            {
                _FilterResult = _AllData;
            }
            evFilterResult?.Invoke(this, _FilterResult);
        }

        private void Filter_Load(object sender, EventArgs e)
        {
           
        }
    }
}

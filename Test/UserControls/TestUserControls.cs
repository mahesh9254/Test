using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.UserControls
{
    public partial class TestUserControls : UserControl
    {
        public event EventHandler GenerateExcel;
        public event EventHandler GenerateXML;
        public event EventHandler SaveXML;
        public event EventHandler SelectXML;
        public event EventHandler SelectExcel;
        public event EventHandler GridClick;
        public TestUserControls()
        {
            InitializeComponent();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            this.GenerateExcel?.Invoke(this, e);
        }

        private void btnxml_Click(object sender, EventArgs e)
        {
            this.GenerateXML?.Invoke(this, e);
        }

        private void btnexcelselect_Click(object sender, EventArgs e)
        {
            this.SelectExcel?.Invoke(this, e);
        }

        private void btnxmlselect_Click(object sender, EventArgs e)
        {
            this.SelectXML?.Invoke(this, e);
        }

        private void btnsavexml_Click(object sender, EventArgs e)
        {
            this.SaveXML?.Invoke(this, e);
        }

        private void xmldataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.GridClick?.Invoke(sender, e);
        }
    }
}

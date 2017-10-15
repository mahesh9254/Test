using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AssignmentSDK;
namespace Test
{
    public partial class Form1 : Form
    {
        List<Services.Entities.User> userList = null;
        List<Services.Entities.User> tempList = null;
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            MainModuleCtrl userControl = new MainModuleCtrl();

        }


        private async void testUserControls1_GenerateExcel(object sender, EventArgs e)
        {
            try
            {
                Services.Excel.ExcelFile gnexcel = new Services.Excel.ExcelFile();
                string val = await gnexcel.CreateWriteExcel();
                MessageBox.Show("Excel file Create :" + val);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void testUserControls1_GenerateXML(object sender, EventArgs e)
        {
            try
            {
                if (testUserControls1.txtexcel.Text.ToString() != null && testUserControls1.txtexcel.Text.ToString() != "")
                {
                    Services.XML.XMLFile gnxml = new Services.XML.XMLFile();
                    string val = await gnxml.ReadCreateXML(testUserControls1.txtexcel.Text.ToString());
                    MessageBox.Show("XML file created :" + val);
                }
                else
                {
                    MessageBox.Show("Select something");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void testUserControls1_SaveXML(object sender, EventArgs e)
        {
            try
            {
                Services.XML.XMLFile gnxml = new Services.XML.XMLFile();
                if (tempList != null)
                {
                    string val = await gnxml.SaveXML(testUserControls1.txtxml.Text.ToString(), tempList);
                    if (val == "Pass")
                    { MessageBox.Show("File Save"); }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Nothing in Grid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void testUserControls1_SelectExcel(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Filter = "Excel Files(.xlsx)| *.xlsx";
                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {

                    testUserControls1.txtexcel.Text = openFileDialog1.FileName.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void testUserControls1_SelectXML(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.Filter = "XML Files|*.xml";
                DialogResult dr = this.openFileDialog1.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK)
                {

                    testUserControls1.txtxml.Text = openFileDialog1.FileName.ToString();

                    Services.XML.XMLFile gnxml = new Services.XML.XMLFile();
                    userList = await gnxml.ReadXML(openFileDialog1.FileName.ToString());
                    tempList = new List<Services.Entities.User>(userList.Select(x => x.Copy()));
                    testUserControls1.xmldataGridView.DataSource = userList;
                    DataGridViewLinkColumn edit = new DataGridViewLinkColumn();
                    edit.HeaderText = "Edit";
                    edit.Text = "Edit";
                    edit.Name = "btnedit";
                    edit.UseColumnTextForLinkValue = true;
                    DataGridViewLinkColumn update = new DataGridViewLinkColumn();
                    update.HeaderText = "Update";
                    update.Text = "Update";
                    update.Name = "btnupdate";
                    update.UseColumnTextForLinkValue = true;
                    DataGridViewLinkColumn cancel = new DataGridViewLinkColumn();
                    cancel.HeaderText = "Cancel";
                    cancel.Text = "Cancel";
                    cancel.Name = "btncancel";
                    cancel.UseColumnTextForLinkValue = true;
                    testUserControls1.xmldataGridView.Columns.Add(edit);
                    testUserControls1.xmldataGridView.Columns.Add(update);
                    testUserControls1.xmldataGridView.Columns.Add(cancel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void testUserControls1_GridClick(object sender, EventArgs e)
        {

            try
            {

                if (((DataGridViewCellEventArgs)e).ColumnIndex == testUserControls1.xmldataGridView.Columns["btnedit"].Index)
                {
                    int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;
                    testUserControls1.xmldataGridView.ReadOnly = false;
                    testUserControls1.xmldataGridView.Rows[rowIndex].ReadOnly = false;
                    for (int i = 0; i < testUserControls1.xmldataGridView.RowCount; i++)
                    {
                        if (rowIndex != i)
                        {
                            for (int j = 1; j < testUserControls1.xmldataGridView.Columns.Count - 2; j++)
                            {
                                testUserControls1.xmldataGridView.Rows[i].Cells[j].ReadOnly = true;
                            }
                        }
                    }

                }

                if (((DataGridViewCellEventArgs)e).ColumnIndex == testUserControls1.xmldataGridView.Columns["btnupdate"].Index)
                {
                    List<Services.Entities.User> dt = testUserControls1.xmldataGridView.DataSource as List<Services.Entities.User>;

                    int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;

                    tempList[rowIndex] = dt[rowIndex].Copy();
                    for (int i = 0; i < testUserControls1.xmldataGridView.RowCount; i++)
                    {
                        if (rowIndex == i)
                        {
                            for (int j = 1; j < testUserControls1.xmldataGridView.Columns.Count - 2; j++)
                            {
                                testUserControls1.xmldataGridView.Rows[i].Cells[j].ReadOnly = true;
                            }
                        }
                    }


                }
                if (((DataGridViewCellEventArgs)e).ColumnIndex == testUserControls1.xmldataGridView.Columns["btncancel"].Index)
                {
                    List<Services.Entities.User> dt = testUserControls1.xmldataGridView.DataSource as List<Services.Entities.User>;

                    int rowIndex = ((DataGridViewCellEventArgs)e).RowIndex;

                    var oldUser = tempList.Where(x => x.UserID == testUserControls1.xmldataGridView.Rows[rowIndex].Cells[0].Value.ToString()).FirstOrDefault();
                    dt[rowIndex] = oldUser;
                    testUserControls1.xmldataGridView.DataSource = dt;
                    testUserControls1.xmldataGridView.Refresh();
                    for (int i = 0; i < testUserControls1.xmldataGridView.RowCount; i++)
                    {
                        if (rowIndex == i)
                        {
                            for (int j = 1; j < testUserControls1.xmldataGridView.Columns.Count - 2; j++)
                            {
                                testUserControls1.xmldataGridView.Rows[i].Cells[j].ReadOnly = true;
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

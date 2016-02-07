using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IeidjtuKCB_Common;
using IeidjtuKCB_DAL;
using System.Windows.Forms;

namespace IeidjtuKCB_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveYear_DAL ActiveYearDal = new ActiveYear_DAL();
            var AllActiveYearList = ActiveYearDal.GetActiveYearForComboBox();
            DataBindingControl.BindComboBox(comboBox_Activeyear,AllActiveYearList, "ATName", "ATID", "--所有学期--");
            comboBox_Activeyear.SelectedValue = AllActiveYearList.Find(d=>d.State=="当前").ATID;
            ActiveYearDal = null;
        }

        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           

           
        }
    }
}

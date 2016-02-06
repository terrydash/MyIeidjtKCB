using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using IeidjtuKCB_Common;
using IeidjtuKCB_Model;
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
            var list = DB.Context.From<Activeyear>()
                                                    .Select(d => new { d.ATID, d.ATName,d.State })
                                                    .OrderBy(Activeyear._.ATID.Desc)
                                                    .ToList();
            
            if (list.Count != 0)
            {
                comboBox_Activeyear.BindComboBox(list, "ATName", "ATID", "--所有学期--");

                var nowlist = list.Find(d => d.State == "当前");
                if (nowlist != null)
                {
                    comboBox_Activeyear.SelectedValue = nowlist.ATID;
                    

                };
                
                

            }
            
            


        }

        private void comboBox_Activeyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (this.comboBox_Activeyear.Items.Count != 0)
            {   int i=-1;
                if (int.TryParse(comboBox_Activeyear.SelectedValue.ToString(),out i))
                {
                    
                    if (i > 0)
                    {
                        var list = DB.Context.From<Vw_Cschedule>()
                                                    .Where(d => d.AtyID == i)
                                                    .OrderBy(Vw_Cschedule._.TCName.Desc)
                                                   .ToList();

                        dataGridView1.DataSource = list;
                    }
                    else if (i ==0)
                    {
                       var list = DB.Context.From<Vw_Cschedule>()
                                                    .OrderBy(Vw_Cschedule._.TCName.Desc)
                                                   .ToList();
                        dataGridView1.DataSource = list;
                    }


                }

            }
        }
    }
}

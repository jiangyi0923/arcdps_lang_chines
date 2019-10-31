using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Ini ini = new Ini(@"./arcdps_lang.ini");
        DataTable dataTable = new DataTable("maps");

        public Form1()
        {
            InitializeComponent();
            dataTable.Columns.Add(new DataColumn("排序", typeof(System.Int32)));
            dataTable.Columns.Add(new DataColumn("英文", typeof(System.String)));
            dataTable.Columns.Add(new DataColumn("中文", typeof(System.String)));
            dataGridView1.DataSource = dataTable;
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"./arcdps_lang_1.ini"))
            {
                File.Delete(@"./arcdps_lang_1.ini");
            }
            Ini ini2 = new Ini(@"./arcdps_lang_1.ini");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][2].ToString().Length > 1)
                {
                    ini2.WriteValue(dataTable.Rows[i][0].ToString(), "lang", dataTable.Rows[i][2].ToString());
                }
            }
            ini2.Save();
        }
        Class1 class1 = new Class1();
        private void Button2_Click(object sender, EventArgs e)
        {
            dataTable.Clear();
            ini.Load();
            for (int i = 0; i < 900; i++)
            {
                
                if (ini.GetValue(i.ToString(), "lang","") !="" || class1.Lvs_()[i] != null)
                {
                    {
                        textBox1.AppendText(i + "=" + ini.GetValue(i.ToString(), "lang") + "\r\n");
                        dataTable.Rows.Add(new object[] { i, class1.Lvs_()[i], ini.GetValue(i.ToString(), "lang") });
                    }
                }
            }
        }

        
    }
}

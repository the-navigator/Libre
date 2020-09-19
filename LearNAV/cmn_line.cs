using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearNAV_Engine;
namespace Libre
{
    public partial class cmn_line : Form
    {
        SQLCmn commandsql = new SQLCmn();
        public cmn_line()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            cmn_history.Items.Add("");
            cmn_history.Items.Add(txt_cmn_.Text);
            lv_results.Items.Clear();
        
            try
            {
               
                commandsql.SearchForRecord(txt_cmn_.Text);


                if (commandsql.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < commandsql.dt.Rows.Count; i++)
                    {

                        DataRow dr = commandsql.dt.Rows[i];
                        ListViewItem fetched_data = new ListViewItem(dr["PKID"].ToString());
                        fetched_data.SubItems.Add(dr["ID"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());
                        fetched_data.SubItems.Add(dr["Author"].ToString());
                        fetched_data.SubItems.Add(dr["GradeLevel"].ToString());
                        fetched_data.SubItems.Add(dr["w_tags"].ToString());
                        fetched_data.SubItems.Add(dr["code_accss"].ToString());

                        lv_results.Items.Add(fetched_data);

                    }
                }
            }
               
            catch (Exception y)
            {
                MessageBox.Show(y.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libre_Update
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            shadow_form.SetShadowForm(this);
            load_data();

        }

        private void load_data()
        {
  
             try
              {
                  Libre_Engine.CheckDatabase.InitialLoad();


                  if (Libre_Engine.CheckDatabase.dt.Rows.Count > 0)
                  {
                      for (int i = 0; i < Libre_Engine.CheckDatabase.dt.Rows.Count; i++)
                      {

                          DataRow dr = Libre_Engine.CheckDatabase.dt.Rows[i];
                          ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                          fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                          fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());

                          resource_list.Items.Add(fetched_data);

                      }
                  }
                  else

                      MessageBox.Show("No data were imported!" + " Counted Data: " + Libre_Engine.CheckDatabase.rowcount.ToString(),
                          "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);


              }
              catch (Exception e)
              {
                  MessageBox.Show(e.Message);
              }
        }

        private void btn_visit_directory_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Environment.CurrentDirectory + "\\Resource Files");

            }
            catch(Exception v)
            {
                MessageBox.Show(v.Message);
            }
        }
    }
}

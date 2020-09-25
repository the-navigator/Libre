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
            Libre_Engine.CheckDatabase.InitialLoad();
             try
              {
                  LoadData.ShowFiltered();


                  if (LoadData.dt.Rows.Count > 0)
                  {
                      for (int i = 0; i < LoadData.dt.Rows.Count; i++)
                      {

                          DataRow dr = LoadData.dt.Rows[i];
                          ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                          fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                          fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());

                          search_results.Items.Add(fetched_data);

                      }
                  }
                  else

                      MessageBox.Show("No data were imported!" + " Counted Data: " + LoadData.rowcount.ToString(),
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

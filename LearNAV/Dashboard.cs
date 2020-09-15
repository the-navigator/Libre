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
using Guna;

namespace LearNAV
{
    public partial class Dashboard : Form
    {
        Filter f = new Filter();
        DatabaseConnection LoadData = new DatabaseConnection();
        ListViewItem selected_to_open = new ListViewItem();
        Boolean is_panel_showed;
        public int card_results;
        public int list_view_count;
        //VARIABLES
        //Color:
   

        public Dashboard()
        {
            InitializeComponent();
            
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
       
            LoadData_Show();
            search_results.Visible = true;
            search_results.BringToFront();
            btn_accs.Enabled = true;
            is_panel_showed = false;
            
            LoadCards();
        }

        //LOADING SCREEN
        /*
        public void launch_loading_screen()
        {
            
        }
         * */

          private void btn_change_view_Click(object sender, EventArgs e)
        {
    
            if (is_panel_showed == true){

                search_results.Visible = true;
                search_results.BringToFront();
                btn_accs.Enabled = true;
                is_panel_showed = false;
            }
            else if (is_panel_showed == false)
            {

                search_results.Visible = false;
                pnl_results.BringToFront();
                btn_accs.Enabled = false;
                is_panel_showed = true;

            }

        }

          private void LoadData_Show()
          {
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            f.FilterName(search_txtbx.Text);
            
            search_results.Clear();
            if (f.dt_filter.Rows.Count > 0)
            {
                for (int i = 0; i < f.dt_filter.Rows.Count; i++)
                {

                    DataRow dr = f.dt_filter.Rows[i];
                    ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                    fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                    fetched_data.SubItems.Add(dr["ResourceLoc"].ToString());

                    search_results.Items.Add(fetched_data);

                }
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accs_Click(object sender, EventArgs e)
        {
            try{
            selected_to_open = search_results.SelectedItems[0];
            OpenResourceSelected(Environment.CurrentDirectory + "\\ResourceFiles\\" + selected_to_open.SubItems[2].Text);
            } catch (Exception v)
            {
                MessageBox.Show("Please select an item from the list.", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

            }
        }
    

        private void OpenResourceSelected(string item_r_path)
        {

            try
            {
                System.Diagnostics.Process.Start(item_r_path);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Resource not found, extract resources from a file?", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {

                    Extract frm = new Extract();
                    frm.Show();
                }
            }
        }
//LOADING CONTROLS

        private void LoadCards()
        {


            try
            {

                for (int i = 0; i < search_results.Items.Count; i++)
                {
                    Resource_Card a = new Resource_Card();
                    a.RSC_ID = search_results.Items[i].Text;
                    a.RSC_NAME = search_results.Items[i].SubItems[1].Text;
                    a.RSC_LOC = search_results.Items[i].SubItems[2].Text;



                    pnl_results.Controls.Add(a);
                    card_results++;

                }


            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                
            }
        }


                
        
        




        //THEMES


        private void theme_mode_CheckedChanged(object sender, EventArgs e)
        {
            //LIGHT THEME
            if (theme_mode.Checked == true) {
                this.BackColor = Color.White;
            main_pnl.BackColor = Color.FromArgb(223, 241, 242);
            btns_panel.BackColor = Color.White;
            btn_quick.BackColor = Color.FromArgb(115, 194, 196);
            lbl_qck_srch.ForeColor = Color.FromArgb(62, 92, 121);
            lbl_libre.ForeColor = Color.FromArgb(19, 28, 37);
            lbl_c.ForeColor = Color.FromArgb(151, 209, 211);
            lbl_version.ForeColor = Color.FromArgb(151, 209, 211);
            label4.ForeColor = Color.FromArgb(130, 205, 185);

            }
            if (theme_mode.Checked == false)
            {
                this.BackColor = Color.FromArgb(19, 28, 37);
                main_pnl.BackColor = Color.FromArgb(27, 41, 54);
                btns_panel.BackColor = Color.FromArgb(19, 28, 37);
                btn_quick.BackColor = Color.FromArgb(115, 194, 196);
                lbl_qck_srch.ForeColor = Color.FromArgb(130, 205, 185);
                lbl_libre.ForeColor = Color.White;
                lbl_c.ForeColor = Color.FromArgb(62, 92, 121);
                lbl_version.ForeColor = Color.FromArgb(62, 92, 121);
                label4.ForeColor = Color.FromArgb(62, 92, 121);
            }

            
        }

        private void btn_advanced_Click(object sender, EventArgs e)
        {
            //check for current theme
            Advance_Search a_form = new Advance_Search();
            a_form.Show();

            if (theme_mode.Checked == true)
            {
                a_form.BackColor = Color.White;
                a_form.pnl1.BackColor = Color.FromArgb(223, 241, 242);
                a_form.chk_author.ForeColor = Color.FromArgb(19, 28, 37);
                a_form.chk_ID.ForeColor = Color.FromArgb(19, 28, 37);
                a_form.chk_tag.ForeColor = Color.FromArgb(19, 28, 37);
                a_form.grp_filter.BorderColor = Color.FromArgb(19, 28, 37);
                a_form.grp_sp_filters.BorderColor = Color.FromArgb(19, 28, 37);
                a_form.grp_filter.ForeColor = Color.FromArgb(19, 28, 37);
                a_form.grp_sp_filters.ForeColor = Color.FromArgb(19, 28, 37);
            }

            if (theme_mode.Checked == false)
            {
                a_form.BackColor = Color.FromArgb(19, 28, 37);
                a_form.pnl1.BackColor = Color.FromArgb(27, 41, 54);
                a_form.chk_author.ForeColor = Color.White;
                a_form.chk_ID.ForeColor = Color.White;
                a_form.chk_tag.ForeColor = Color.White;
                a_form.grp_filter.BorderColor = Color.White;
                a_form.grp_sp_filters.BorderColor = Color.White;
                a_form.grp_filter.ForeColor = Color.White;
                a_form.grp_sp_filters.ForeColor = Color.White;
            }
        }

        private void search_txtbx_TextChanged(object sender, EventArgs e)
        {
            if (search_txtbx.Text == null)
            {
                search_results.Items.Clear();
                LoadData_Show();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            cmn_line cmn = new cmn_line();
            cmn.Show();
        }

      

       
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

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
            LoadData();

        }

        private void LoadData()
        {
  
             try
              {
                 // Libre_Engine.CheckDatabase l = new Libre_Engine.CheckDatabase();
                 //LearNAV_Engine.DatabaseConnection d = new LearNAV_Engine.DatabaseConnection();
                 Libre_Engine.CheckDatabase.InitialLoad();


                  if (Libre_Engine.CheckDatabase.dt.Rows.Count > 0)
                  {
                      for (int i = 0; i < Libre_Engine.CheckDatabase.dt.Rows.Count; i++)
                      {

                          DataRow dr = Libre_Engine.CheckDatabase.dt.Rows[i];
                          ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                          fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                          fetched_data.SubItems.Add(dr["GradeLevel"].ToString());

                          resource_list.Items.Add(fetched_data);

                      }
                  }
                  else

                      MessageBox.Show("Error");


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

        private void btn_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/the-navigator/libre");
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search_name(search_box.Text);
        }

        void search_name(string var_st)
        {
            try
            {
                // Libre_Engine.CheckDatabase l = new Libre_Engine.CheckDatabase();
                //LearNAV_Engine.DatabaseConnection d = new LearNAV_Engine.DatabaseConnection();

                Libre_Engine.AdvanceSearch.searchName(var_st);


                if (Libre_Engine.AdvanceSearch.dt.Rows.Count > 0)
                {
                    for (int i = 0; i < Libre_Engine.AdvanceSearch.dt.Rows.Count; i++)
                    {

                        DataRow dr = Libre_Engine.AdvanceSearch.dt.Rows[i];
                        ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                        fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                        fetched_data.SubItems.Add(dr["GradeLevel"].ToString());

                        resource_list.Clear();
                        resource_list.Items.Add(fetched_data);

                    }
                }
                else

                    MessageBox.Show("Error");


            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}

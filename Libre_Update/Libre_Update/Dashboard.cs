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
        bool enableTypeSearching = false;
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
            resource_list.Items.Clear();
            Libre_Engine.VarHold.dataTableHolder.Clear();
            searchName(search_box.Text);
        }

        private void searchName(string var_st)
        {
        
            try
            {
                // Libre_Engine.CheckDatabase l = new Libre_Engine.CheckDatabase();
                //LearNAV_Engine.DatabaseConnection d = new LearNAV_Engine.DatabaseConnection();
                Libre_Engine.QuickSearch searchResourceName = new Libre_Engine.QuickSearch();
                searchResourceName.SearchName(var_st);
                
             
                using (Libre_Engine.VarHold.dataTableHolder)
                {
                    if (Libre_Engine.VarHold.dataTableHolder.Rows.Count > 0)
                    {
                        for (int i = 0; i < Libre_Engine.VarHold.dataTableHolder.Rows.Count; i++)
                        {
                            DataRow dr = Libre_Engine.VarHold.dataTableHolder.Rows[i];
                            ListViewItem fetched_data = new ListViewItem(dr["ID"].ToString());
                            fetched_data.SubItems.Add(dr["ResourceN"].ToString());
                            fetched_data.SubItems.Add(dr["GradeLevel"].ToString());

                            resource_list.Items.Add(fetched_data);
                  
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void search_box_DoubleClick(object sender, EventArgs e)
        {
            
           

        }

        private void search_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Enter))
            {
                searchName(search_box.Text);
            }
        }

       
    }

    class SortItemList
    {
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libre
{
    public partial class Loding_Screen : Form
    {
    	public int loaded_data;
        public int total_data;
        public Loding_Screen()
        {
            InitializeComponent();
        }

        private void Loding_Screen_Load(object sender, EventArgs e)
        {
        	prog.DoWork += new DoWorkEventHandler(prog_DoWork);
        	  prog.RunWorkerAsync();
        }

        private void prog_DoWork(object sender, DoWorkEventArgs e)
        {
        	_load_progress(loaded_data, total_data);

        }

        private void _load_progress(int _loaded_data, int _total_data)
        {
            

        	try 
        	{
        	 int progress = Convert.ToInt32(100 * _loaded_data / 100 * _total_data);
        	loading_progress.Value = progress;
           
        	}catch(Exception e) {
                MessageBox.Show(e.Message);
            }
            finally
            {
                MessageBox.Show("lol");
            }
            
         
                

            }

        }
        }

        
    


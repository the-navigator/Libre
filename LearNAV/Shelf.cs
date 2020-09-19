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

    public partial class Shelf : Form
    {
        //Variables
        int size_default_x = 967;
        int size_default_y = 568;

        int size_expanded_x = 1252;

        int ext_default_location_x = 998;
        int ext_moved_x = 1250;
        public Shelf()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void expand()
        {
            this.Width = size_expanded_x;





        }

         static void shrink()
        {
            
        }

        private void btn_new_resource_Click(object sender, EventArgs e)
        {

        }
    }
}

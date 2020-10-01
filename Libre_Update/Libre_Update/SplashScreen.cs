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
    public partial class SplashScreen : Form
    {
        int i = 0;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void LoadingTime_Tick(object sender, EventArgs e)
        {

            i += 1;
            if (i == 15)
            {
                LoadingTime.Stop();
                Dashboard d = new Dashboard();
                d.Show();
                
            }
           

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            ShadowForm.SetShadowForm(this);
            
            LoadingTime.Tick += new EventHandler(this.LoadingTime_Tick);
            LoadingTime.Start();

        }
    }
}

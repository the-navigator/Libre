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
    public static partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            shadow.SetShadowForm(this);
        }

        private void btnLoadLibrary_Click(object sender, EventArgs e)
        {
            string pathToDB;
            fileOpen.ShowDialog();
           // pathToDB = fileOpen.FileName;
            /*
            pathToDB = fileOpen.SafeFileName;
            Libre_Engine.DatabasePackageControl.SetName(pathToDB);
            Libre_Engine.VarHold.AssignName();
             * */
            Libre_Engine.DatabasePackageControl.GetName();
            Libre_Engine.VarHold.AssignName();
            Dashboard d = new Dashboard();
            d.Show();
            Application.Run(new Dashboard());
           Home.Close();
           // pathToDB = fileOpen.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libre_Update
{
    public partial class Resource_Card : UserControl
    {
        public Resource_Card()
        {
            InitializeComponent();
        }

        private void Resource_Card_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}

using Quiz_Form;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animale_Form
{
    public partial class FormProfesor : Form
    {
        public FormProfesor()
        {
            InitializeComponent();
        }

        private void buttonStartUp_Click(object sender, EventArgs e)
        {
            var frm = new FormStartUp();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }
    }
}

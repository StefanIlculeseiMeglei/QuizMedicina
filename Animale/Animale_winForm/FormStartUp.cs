using Animale_Form;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Form
{
    public partial class FormStartUp : Form
    {
        public FormStartUp()
        {
            InitializeComponent();
        }

        private void buttonChangeForm_Click(object sender, EventArgs e)
        {
           
                var frm = new Form1();
                frm.Location = this.Location;
                frm.StartPosition = FormStartPosition.Manual;
                frm.FormClosing += delegate { this.Close(); };
                frm.Show();
                this.Hide();
        }

        private void buttonChangeForm1_Click(object sender, EventArgs e)
        {
            var frm = new FormStudent();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
           
            frm.Show();
            this.Hide();
        }

        private void buttonChangeForm2_Click(object sender, EventArgs e)
        {
            var frm = new FormProfesor();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
            frm.Show();
            this.Hide();
        }

        private void buttonChangeForm3_Click(object sender, EventArgs e)
        {
            var frm = new FormAdministrator();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close(); };
           
            frm.Show();
            this.Hide();
        }
    }
}

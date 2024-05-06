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
    public partial class FormStudent : Form
    {
        public FormStudent()
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

        private void buttonPopulateList_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.Items.Add(new ListViewItem("PIU"));
            this.listView1.Items.Add(new ListViewItem("BD"));
            this.listView1.Items.Add(new ListViewItem("PALG"));
            this.listView1.Items.Add(new ListViewItem("MN"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowSelectedEx_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                Console.WriteLine("There are no selected items");
                return;
            }
            this.label1.Text = this.listView1.SelectedItems[0].Text;
            Console.WriteLine(this.label1.Text);
            this.label1.Invalidate();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                Console.WriteLine("There are no selected items");
                return;
            }
            this.label1.Text = this.listView1.SelectedItems[0].Text;
            var frm = new FormQuiz(this.listView1.SelectedItems[0].Text);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

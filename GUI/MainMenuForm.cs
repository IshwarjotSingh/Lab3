using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.GUI;

namespace Lab3.GUI
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm stuForm = new StudentForm();
            this.Hide();
            stuForm.ShowDialog();
        }
    }
}

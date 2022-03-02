using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3__Windows_Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {
            //The part that makes it work!
            string name = txtInput.Text;
            lblMessage.Text = "Greetings " + name;
        }
    }
}

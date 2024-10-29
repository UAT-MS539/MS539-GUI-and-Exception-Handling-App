using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_GUI_and_Exception_Handling_App
{
    public partial class Form2 : Form
    {
        public Form2(string fromForm1)
        {
            InitializeComponent();
            totalPayLabel.Text = fromForm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();                
        }
    }
}

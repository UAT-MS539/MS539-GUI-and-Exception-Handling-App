namespace MS539_GUI_and_Exception_Handling_App
{
    /*Douglas Little
 * MS539 Gui and Exception Hndling App
 * I estimate this will take me about an hour to finish
 * Actually took somewhere between 1 1/2 and 2 hours altogether, I kept getting stuck on something and had to take a break
 * to figure out something else to try.
 */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hourlyRateTextBox.Text = String.Empty;
            hoursTextBox.Text = String.Empty;
            totalLabel.Text = "";
            hoursTextBox.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double hours;
            decimal rate, total = 0;
            if (double.TryParse(hoursTextBox.Text, out hours))
            {
                if (decimal.TryParse(hourlyRateTextBox.Text, out rate))
                {
                    try
                    {
                        total = (decimal)hours * rate;
                        totalLabel.Text = total.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Please enter the correct number of hours.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid decimal.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid double.");
            }
                   



            Form2 form2 = new Form2(totalLabel.Text);
            form2.Show();
            hourlyRateTextBox.Text = String.Empty;
            hoursTextBox.Text = String.Empty;
            totalLabel.Text = "";
            hoursTextBox.Focus();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hourlyRateTextBox.Text = String.Empty;
            hoursTextBox.Text = String.Empty;
            totalLabel.Text = "";
            hoursTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

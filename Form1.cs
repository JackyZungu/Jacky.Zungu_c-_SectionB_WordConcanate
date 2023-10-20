using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jacky.Zungu_c__SectionB_WordConcanate
{
    public partial class Form1 : Form
    {
        private ArrayList word = new ArrayList();
        private ArrayList concatenatedWords = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            CenterToParent();

            lblConcatenatedWord.BackColor = Color.White;
            lblConcatenatedWord.Font = new Font("Arial", 10);

            // Set the Dock property of the Label control to bottom.
            lblConcatenatedWord.Dock = DockStyle.Bottom;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnterWrd.Text))
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(cbWord1.Items.Contains(txtEnterWrd.Text)) 
            {
                MessageBox.Show("The word has already been entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            word.Add(txtEnterWrd.Text);
            

            cbWord1.Items.Add(txtEnterWrd.Text);
            cbWord2.Items.Add(txtEnterWrd.Text);

           
            txtEnterWrd.Clear();

            cbWord1.SelectedItem = txtEnterWrd.Text;
            cbWord2.SelectedItem = txtEnterWrd.Text;

            MessageBox.Show("The new word has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            string textBoxText = txtEnterWrd.Text;
            if (rBtn.Checked || rBtn2.Checked)
            {
                // Check if a word has been selected from a ComboBox control
                if (cbWord2.SelectedItem == null && cbWord2.SelectedItem == null)
                {
                    // Display a MessageBox
                    MessageBox.Show("Please select a word from a ComboBox control.");
                    return;
                }
                // Remove the selected word from the corresponding ComboBox control.
                else if (cbWord1.SelectedItem != null)
                {
                    cbWord1.Items.Remove(cbWord1.SelectedItem);
                }
                else if (cbWord2.SelectedItem != null)
                {
                    cbWord2.Items.Remove(cbWord2.SelectedItem);
                }
                MessageBox.Show("The word has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
 
            }
            else

            {
                if (cbWord1.SelectedItem == null || cbWord2.SelectedItem == null)
                {
                    MessageBox.Show("Please select a word from both ComboBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cbWord1.SelectedItem.ToString() == cbWord2.SelectedItem.ToString())
                {
                    MessageBox.Show("Please select different words from the ComboBox controls.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                concatenatedWords.Add(txtEnterWrd.Text);

                string concatenatedWord = cbWord1.SelectedItem.ToString() + cbWord2.SelectedItem.ToString();

                lblConcatenatedWord.Text = concatenatedWord;
            }

            string[] txtEnterWord = textBoxText.Split(' ');

            if (txtEnterWord.Length > 1 && txtEnterWord[0] == txtEnterWord[1])
            {
                MessageBox.Show("The TextBox contains the same word twice.");
            }
        }

        private void rBtn_CheckedChanged(object sender, EventArgs e)
        {

            if(rBtn.Checked)
            {
                btnConcatenate.Text = "Remove Item";
            }
            else
            {
                btnConcatenate.Text = "Concatenate";
            }
        }

        private void rBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn2.Checked)
            {
                btnConcatenate.Text = "Remove Item";
            }
            else
            {
                btnConcatenate.Text = "Concatenate";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

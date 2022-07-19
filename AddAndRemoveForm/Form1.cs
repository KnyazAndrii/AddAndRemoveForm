using System;
using System.Windows.Forms;

namespace AddAndRemoveForm
{
    public partial class AddAndRemoveForm : Form
    {
        public AddAndRemoveForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string toAdd = textBoxToAddWords.Text;

            listBoxWithWords.Items.Add(toAdd);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string toRemove = listBoxWithWords.SelectedItem.ToString();

            listBoxWithWords.Items.Remove(toRemove);
            buttonRemove.Enabled = false;

        }

        private void textBoxToAddWords_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(textBoxToAddWords.Text))
            {
                buttonAdd.Enabled = true;
            }
            else
            {
                buttonAdd.Enabled = false;
            }
        }

        private void listBoxWithWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Enabled = true;
        }
    }
}


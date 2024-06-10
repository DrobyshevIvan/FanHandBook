using Course.Model;
using System;
using System.Windows.Forms;

namespace Course.View
{
    public partial class AddGameForm : Form
    {
        public Game NewGame { get; private set; }

        public AddGameForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && !string.IsNullOrEmpty(txtOpponent.Text) && !string.IsNullOrEmpty(txtResult.Text))
            {
                NewGame = new Game
                {
                    Date = dateTimePicker1.Value,
                    Opponent = txtOpponent.Text,
                    Result = txtResult.Text
                };
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заповінть всі поля");
            }
        }
    }
}
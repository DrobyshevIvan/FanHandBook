using Course.View;

namespace Course;

public partial class MainMenu : Form
{
    public MainMenu()
    {
        InitializeComponent();
    }

    private void btnPlayers_Click(object sender, EventArgs e)
    {
        AllAthletes allAthletes = new AllAthletes();
        Hide();
        allAthletes.ShowDialog();
        Close();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }
}
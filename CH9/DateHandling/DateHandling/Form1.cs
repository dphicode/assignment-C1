namespace DateHandling;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculateDays_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the days until due date
        DateTime currDt = DateTime.Today;
        DateTime futureDt = DateTime.Parse(txtFutureDate.Text);
        TimeSpan span = futureDt.Subtract(currDt);
        int daysDue = span.Days;
        MessageBox.Show($"Current: {currDt.ToShortDateString()} \n Future: {futureDt.ToShortDateString()} \n {daysDue}");

    }

    private void btnCalculateAge_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the age
        DateTime currDt = DateTime.Today;
        DateTime bDay = DateTime.Parse(txtBirthDate.Text);
        int calcAge = currDt.Year - bDay.Year;
        if (currDt.DayOfYear < bDay.DayOfYear)
        {
            calcAge -= 1;
        }
        MessageBox.Show($"Current: {currDt.ToShortDateString()} \n Birthday: {bDay.ToShortDateString()} \n Age: {calcAge}");
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}

namespace RaceReady
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Add single items
            chargedComboBox.Items.Add("YES");
            chargedComboBox.Items.Add("NO");

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Intitialize variables for tires
            decimal frontLeft = 0;
            decimal frontRight = 0;
            decimal rearLeft = 0;
            decimal rearRight = 0;
            bool tiresReady;

            // Get the values from the text boxes and convert them to decimal
            bool isFrontLeftValid = decimal.TryParse(frontLeftTextBox.Text, out frontLeft);
            bool isFrontRightValid = decimal.TryParse(frontRightTextBox.Text, out frontRight);
            bool isRearLeftValid = decimal.TryParse(rearLeftTextBox.Text, out rearLeft);
            bool isRearRightValid = decimal.TryParse(rearRightTextBox.Text, out rearRight);

            // Decision if tires are good for show
            if (isFrontLeftValid && isFrontRightValid && isRearLeftValid && isRearRightValid)
            {
                if (frontLeft >= 26 && frontRight >= 26 && rearLeft >= 26 && rearRight >= 26)
                {
                    tiresReady = true;
                }
                else
                {
                    tiresReady = false;
                }
            }
            else
            {
                tiresReady = false;
            }

            // Display the result in the result
            if (tiresReady && string.Equals(chargedComboBox.SelectedItem?.ToString(), "YES", StringComparison.OrdinalIgnoreCase))
            {
                resultsTextBox.Text = "Ready!";
            }
            else
            {
                resultsTextBox.Text = "NOT ready!";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

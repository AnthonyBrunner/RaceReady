namespace RaceReady
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


        }
    }
}

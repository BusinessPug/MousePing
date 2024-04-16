namespace MousePing
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.okButton.Click += okButton_Click;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Check the state of the checkbox and store the preference
            SavePreference(dontShowThisAgainCheckBox.Checked);

            // Close the WelcomeForm
            this.Close();
        }

        private void SavePreference(bool dontShowAgain)
        {
            Properties.Settings.Default.ShowWelcomeMessage = !dontShowAgain;
            Properties.Settings.Default.Save();
        }
    }
}

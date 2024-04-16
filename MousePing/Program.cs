namespace MousePing
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (string.IsNullOrEmpty(Properties.Settings.Default.Hotkey))
            {
                Properties.Settings.Default.Hotkey = "F6";
                Properties.Settings.Default.Save();
            }

            Keys defaultHotkey = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.Hotkey);

            // Check if we should show the welcome message
            if (Properties.Settings.Default.ShowWelcomeMessage)
            {
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.ShowDialog(); // ShowDialog makes the form modal, so execution will wait here until it closes
            }

            // Then run the main application form
            Form1 mainForm = new Form1();
            Application.Run(mainForm);
        }
    }
}
using System.Runtime.InteropServices;

namespace MousePing
{
    public partial class Form1 : Form
    {
        private SonarForm sonarFormInstance = new SonarForm();
        private int hotkeyId = 1;
        private Keys hotkey = Keys.None;
        private uint hotkeyModifiers = 0;

        public Form1()
        {
            InitializeComponent();
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            sonarFormInstance.Show();
            sonarFormInstance.Hide();
            Keys hotkey = (Keys)Enum.Parse(typeof(Keys), Properties.Settings.Default.Hotkey);
            RegisterHotkey(hotkey, 0);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == hotkeyId) // WM_HOTKEY
            {
                sonarFormInstance.StartAnimation(); // Start the sonar animation
            }
            base.WndProc(ref m);
        }

        public bool RegisterHotkey(Keys key, uint modifiers)
        {
            hotkey = key;
            hotkeyModifiers = modifiers;
            return RegisterHotKey(this.Handle, hotkeyId, hotkeyModifiers, (uint)key);
        }

        public void UnregisterHotkey()
        {
            UnregisterHotKey(this.Handle, hotkeyId);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ensure only one instance of the SettingsForm is open at a time
            if (Application.OpenForms.OfType<SettingsForm>().Any())
            {
                Application.OpenForms.OfType<SettingsForm>().First().Focus();
            }
            else
            {
                SettingsForm settingsForm = new SettingsForm();
                settingsForm.Hotkey = this.hotkey; // Pass the current hotkey to SettingsForm
                settingsForm.HotkeyModifiers = this.hotkeyModifiers; // Pass current modifiers if any
                settingsForm.FormClosed += SettingsForm_FormClosed; // Subscribe to the closed event
                settingsForm.Show();
            }
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsForm settings = sender as SettingsForm;
            if (settings != null)
            {
                // Unregister the old hotkey and register the new one
                UnregisterHotkey();
                if (RegisterHotkey(settings.Hotkey, settings.HotkeyModifiers))
                {
                    // Successfully registered new hotkey
                }
                else
                {
                    throw new Exception("Failed to register hotkey");
                }
            }
        }

        private void MousePing_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("About this app...", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    }
}

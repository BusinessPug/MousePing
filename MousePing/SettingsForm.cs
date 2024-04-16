namespace MousePing
{
    public partial class SettingsForm : Form
    {
        public Keys Hotkey { get; set; }
        public uint HotkeyModifiers { get; set; }
        private bool isSettingHotkey = false;

        public event Action<Keys, uint> OnHotkeySet;

        public SettingsForm()
        {
            InitializeComponent();
            btnSetHotkey.Click += btnSetHotkey_Click;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(SettingsForm_KeyDown);
        }

        private void btnSetHotkey_Click(object sender, EventArgs e)
        {
            lblHotkey.Text = "Press the key you want to set...";
            isSettingHotkey = true;
            this.Focus();
        }

        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Properties.Settings.Default.Hotkey = Hotkey.ToString();
                Properties.Settings.Default.Save();
            }
            this.Close();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isSettingHotkey)
            {
                Hotkey = e.KeyCode;
                HotkeyModifiers = (uint)e.Modifiers;

                string hotkeyDisplay = $"{(e.Control ? "Ctrl+" : "")}{(e.Alt ? "Alt+" : "")}{(e.Shift ? "Shift+" : "")}{e.KeyCode}";

                lblHotkey.Text = $"Hotkey set to: {hotkeyDisplay}";

                OnHotkeySet?.Invoke(Hotkey, HotkeyModifiers);

                isSettingHotkey = false;
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}

namespace MousePing
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            btnSetHotkey = new Button();
            lblHotkey = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnSetHotkey
            // 
            btnSetHotkey.Location = new Point(10, 70);
            btnSetHotkey.Name = "btnSetHotkey";
            btnSetHotkey.Size = new Size(100, 30);
            btnSetHotkey.TabIndex = 0;
            btnSetHotkey.Text = "Set Hotkey";
            btnSetHotkey.UseVisualStyleBackColor = true;
            btnSetHotkey.Click += btnSetHotkey_Click;
            // 
            // lblHotkey
            // 
            lblHotkey.AutoSize = true;
            lblHotkey.Location = new Point(10, 20);
            lblHotkey.Name = "lblHotkey";
            lblHotkey.Size = new Size(350, 15);
            lblHotkey.TabIndex = 1;
            lblHotkey.Text = "Welcome to the application! Please set your hotkey.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 40);
            checkBox1.Name = "checkBox";
            checkBox1.Size = new Size(370, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Save this hotkey for the next time the application is started";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(120, 70);
            button1.Name = "btnSaveKey";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSaveKey_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 120);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(lblHotkey);
            Controls.Add(btnSetHotkey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnSetHotkey;
        private Label lblHotkey;
        private Button btnSaveKey;
        private CheckBox checkBox1;
        private Button button1;
    }
}
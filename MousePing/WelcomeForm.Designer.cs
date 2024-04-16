namespace MousePing
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            label1 = new Label();
            dontShowThisAgainCheckBox = new CheckBox();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(380, 60);
            label1.TabIndex = 0;
            label1.Text = "Welcome to MouseSonar! \r\nthe default hotkey is F6 and can be changed in the settings, \r\naccesible by rightclicking the icon in your System Tray!";
            // 
            // dontShowThisAgainCheckBox
            // 
            dontShowThisAgainCheckBox.AutoSize = true;
            dontShowThisAgainCheckBox.Location = new Point(10, 80);
            dontShowThisAgainCheckBox.Name = "dontShowThisAgainCheckBox";
            dontShowThisAgainCheckBox.Size = new Size(240, 19);
            dontShowThisAgainCheckBox.TabIndex = 1;
            dontShowThisAgainCheckBox.Text = "Don't show this again";
            dontShowThisAgainCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Location = new Point(160, 110);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 150);
            Controls.Add(okButton);
            Controls.Add(dontShowThisAgainCheckBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WelcomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private CheckBox checkBox1;
        private Button okButton;
        private CheckBox dontShowThisAgainCheckBox;
    }
}
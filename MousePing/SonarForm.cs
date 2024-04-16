namespace MousePing
{
    public partial class SonarForm : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int radius = 0;
        private int maxRadius = 350;
        private float penWidth = 10;

        public SonarForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.Height = maxRadius * 2 + (int)penWidth * 2;
            this.animationTimer = new System.Windows.Forms.Timer();
            this.animationTimer.Interval = 10;
            this.animationTimer.Tick += AnimationTimer_Tick;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (radius < maxRadius)
            {
                int x = (this.Width / 2) - radius;
                int y = (this.Height / 2) - radius;

                using (Pen pen = new Pen(Color.Blue, penWidth) { DashStyle = System.Drawing.Drawing2D.DashStyle.Solid })
                {
                    e.Graphics.DrawEllipse(pen, x, y, radius * 2, radius * 2);
                }
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (radius < maxRadius)
            {
                radius += 10;
                this.Invalidate();
            }
            else
            {
                animationTimer.Stop();
                this.Hide();
                radius = 0;
            }
        }

        public void StartAnimation()
        {
            Point cursorPos = Cursor.Position;
            this.Location = new Point(cursorPos.X - this.Width / 2, cursorPos.Y - this.Height / 2);
            this.Show();
            animationTimer.Start();
        }
    }
}

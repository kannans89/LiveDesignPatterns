namespace WinFormsTEmplateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            MessageBox.Show("OnLoad");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            Rectangle rect = new Rectangle(10, 10, 100, 50);
            g.FillRectangle(Brushes.Blue, rect);
            g.DrawString("Hello, OnPaint!", Font,
                Brushes.White, rect);
            MessageBox.Show("onPaint");
        }
    }
}
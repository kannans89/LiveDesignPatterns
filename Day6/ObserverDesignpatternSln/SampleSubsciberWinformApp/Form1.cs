namespace SampleSubsciberWinformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //button1.AddClickSubscirber(GodSubsciber);
            //button1.AddClickSubscirber(DevilSubscriber);

           // button1.Click += EventHandler
            button1.Click += GodSubscriber;
            button1.Click += DevilSubscriber;

        }

       

        public void GodSubscriber(object sender,EventArgs e) {
           MessageBox.Show("God is listneing");
        }
        public void DevilSubscriber(object sender,EventArgs e)
        {
            MessageBox.Show("Devil is listneing");
        }
    }
}
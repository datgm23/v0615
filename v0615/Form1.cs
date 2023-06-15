namespace v0615
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int vx1 = rand.Next(-10, 11);
        int vy1 = rand.Next(-10, 11);
        int vx2 = rand.Next(-10, 11);
        int vy2 = rand.Next(-10, 11);
        int vx3 = rand.Next(-10, 11);
        int vy3 = rand.Next(-10, 11);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx1;
            label1.Top += vy1;

            label2.Left += vx2;
            label2.Top += vy2;

            label3.Left += vx3;
            label3.Top += vy3;
        }
    }
}
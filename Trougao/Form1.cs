namespace Trougao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random r = new Random();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Point o = new Point(e.X, e.Y);
                Trougao t = new Trougao(o);
                t.A = Convert.ToInt32(textBox1.Text);
                Graphics g = CreateGraphics();
                Color boja = Color.FromArgb(160, r.Next(256), r.Next(256), r.Next(256));
                t.Boji(g, boja);
                t.Crtaj(g, Color.Black);
                textBox2.Text = t.Acm.ToString("0.00");
                double obim = 3 * t.Acm;
                textBox3.Text = obim.ToString("0.00");
            }
            catch (Exception Izuzetak)
            {
                MessageBox.Show(Izuzetak.Message, "Greska");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
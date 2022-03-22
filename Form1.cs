namespace InvitacionDeAmor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - btnNo.Width);
            int y = r.Next(0, this.Height - btnNo.Height);
            btnNo.Location = new Point(x, y);
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if (btnNo.Location == btnSi.Location || btnNo.Location == label1.Location) ;
            {
                MoverBoton();
            }
        }
    }
}
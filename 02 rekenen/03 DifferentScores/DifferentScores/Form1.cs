
namespace UpAndDown
{
    public partial class Form1 : Form
    {

        int score = 0;
        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                score ++;
            }
            if (e.KeyCode == Keys.E)
            {
                score += 5;
            }
            if (e.KeyCode == Keys.W)
            {
                score --;
            }
            if (e.KeyCode == Keys.Delete)
            {
                score -= 5;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(Color.Black);

            e.Graphics.DrawString("Score: " + score, Font, Brushes.White, 50, 50);

        }

        public void DoLogic(float frametime)
        {
        }
    }
}

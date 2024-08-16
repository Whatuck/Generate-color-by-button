using System.Drawing;

namespace HueGen
{
    public partial class Form1 : Form
    {
        int number;
        int colorR;
        int colorG;
        int colorB;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            Random rnd = new Random();
            number = rnd.Next(2, 15);
            int o = number - 10;
            if (number <= 4)
                label1.Text = "Итого вышло " + number.ToString() + " цвета";
            else
                label1.Text = "Итого вышло " + number.ToString() + " цветов";
            for (int i = number; i > 0; i--)
            {
                colorR = rnd.Next(0, 255);
                colorG = rnd.Next(0, 255);
                colorB = rnd.Next(0, 255);
                SolidBrush brushE = new SolidBrush(Color.FromArgb(colorR, colorG, colorB));
                if (i > 10)
                    g.FillEllipse(brushE, 800 / (o + 1) * (i - 10) + 10, 350, 60, 60);
                else
                {
                    if (number >= 10)
                        g.FillEllipse(brushE, 80 * i + 10, 250, 60, 60);
                    else
                        g.FillEllipse(brushE, 800 / number * i - 300 / number + 10, 250, 60, 60);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

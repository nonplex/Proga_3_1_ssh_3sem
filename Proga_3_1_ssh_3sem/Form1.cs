using System;
using System.IO;
using System.Windows.Forms;



namespace proga_3_1_ssh_3sem
{

    public partial class Form1 : Form
    {
        private double[] X;
        private double[] Y;
        private const int N = 10;

        public Form1()
        {
            InitializeComponent();

            X = new double[N];
            for (int i = 0; i < N; i++)
            {
                double sum = 1.0;

 
                X[i] = sum;
            }
            Y = new double[N];
            for (int i = 0; i < N; i++)
            {
                double sum = 1.0;


                Y[i] = sum;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очистка массива X и его инициализация с размером n
            X = new double[N];
            for (int i = 0; i < N; ++i)
            {
                double sum = 3.0;

                for (int j = 1; j <= i + 1; ++j)
                {
                    sum = Math.Sqrt(sum + 3.0 * X[i]);
                }

                X[i] = sum;
            }
        }

        private void calculateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Y = new double[N];
            for (int i = 0; i < N; ++i)
            {
                double sum = 0.0;

                for (int j = 0; j <= i; ++j)
                {
                    sum += X[j];
                }

                sum += X[i] * X[i];

                Y[i] = X[i] / (1 + sum);
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, Array.ConvertAll(Y, value => value.ToString()));
            }
        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                X = Array.ConvertAll(lines, line => double.Parse(line));
            }
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
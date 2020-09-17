using Algorithm;
using System.Windows.Forms;

namespace SortAlg
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                algorithm.Items.Add(value);
                label1.Text += " " + value;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            algorithm.Sort();
            foreach (var item in algorithm.Items)
            {
                label2.Text += " " + item;
            }
        }
    }
}

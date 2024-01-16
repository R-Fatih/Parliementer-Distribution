using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MV_Dağılımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = (Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(textBox1.Text) / 100).ToString("n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = (Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(textBox1.Text) / 100).ToString("n");

        }
        int x = 70;
        int y = 133;
        List<double> secmen = new List<double>();
        List<Label> labels = new List<Label>();
        StringBuilder sb = new StringBuilder();
        public class Parti
        {
            public bool Baraj { get; set; }
            public double Oran { get; set; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            secmen.Clear();
            labels.Clear();
            sb.Clear();

            NumericUpDown[] numericUpDowns = new NumericUpDown[] { numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7 };
            for (int a = 0; a < numericUpDowns.Length; a++)
            {
                for (int i = 1; i < 12; i++)
                {


                    Label label = new Label();
                    label.Text = (Convert.ToDouble(label4.Text) * Convert.ToDouble(numericUpDowns[a].Value) / 100 / i).ToString("n");
                    label.Location = new Point(x, y);

                    y = y + 30;

                    this.Controls.Add(label);
                    if (a != 5)
                        secmen.Add(Convert.ToDouble(label.Text));
                    else
                        secmen.Add(0);

                    labels.Add(label);
                }
                x = x + 100;
                y = 133;

            }
            secmen.Sort();
            secmen.Reverse();
            for (int a = 0; a < labels.Count; a++)
            {
                listBox1.Items.Add(secmen[a].ToString("n"));
            }
            for (int i = 0; i < secmen.Count; i++)
            {
                if (listBox1.FindString(labels[i].Text.ToString()) != -1 && listBox1.FindString(labels[i].Text.ToString()) < Convert.ToInt32(textBox2.Text))
                {
                    labels[i].BackColor = Color.Red;
                }
                sb.Append(labels[i].Text.ToString() + "--" + listBox1.Items[i].ToString() + "--" + listBox1.FindString(labels[i].Text.ToString()) + "\n");
            }
            File.WriteAllText("a.txt", sb.ToString());

        }
    }
}

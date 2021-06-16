using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormszad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bKB_Click(object sender, EventArgs e)
        {
            if (textBoxKB.Text != "")
            {
                try
                {
                    var a = double.Parse(textBoxKB.Text);
                    var b = comboBoxKB.SelectedIndex;


                    if (b == 0)
                    {
                        var w = a * 1.23;
                        textBoxWKB.Text = w.ToString();

                    }

                    else if (b == 1)
                    {
                        var w = a * 1.08;
                        textBoxWKB.Text = w.ToString();

                    }
                    else if (b == 2)
                    {
                        var w = a * 1.07;
                        textBoxWKB.Text = w.ToString();

                    }
                    else if (b == 3)
                    {
                        var w = a * 1.05;
                        textBoxWKB.Text = w.ToString();

                    }
                    else
                    {
                        var w = a * 1;
                        textBoxWKB.Text = w.ToString();

                    }

                }
                catch
                {

                    MessageBox.Show("nie podano liczb");
                }


            }
            else
                MessageBox.Show("nie podano wartości");
        }

        private void comboBoxKB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bBN_Click(object sender, EventArgs e)
        {
            if (textBoxBN.Text != "")
            {
                try
                {
                    var a = double.Parse(textBoxBN.Text);
                    var b = comboBoxBN.SelectedIndex;


                    if (b == 0)
                    {
                        var w = a * 0.813;

                        w = Math.Round(w, 2);
                        textBoxWBN.Text = w.ToString();

                    }

                    else if (b == 1)
                    {
                        var w = a * 0.92592;
                        w = Math.Round(w, 2);
                        textBoxWBN.Text = w.ToString();

                    }
                    else if (b == 2)
                    {
                        var w = a * 0.93457;
                        w = Math.Round(w, 2);
                        textBoxWBN.Text = w.ToString();

                    }
                    else if (b == 3)
                    {
                        var w = a * 0.95238;
                        w = Math.Round(w, 2);
                        textBoxWBN.Text = w.ToString();

                    }
                    else
                    {
                        var w = a * 1;
                        w = Math.Round(w, 2);
                        textBoxWBN.Text = w.ToString();

                    }

                }
                catch
                {

                    MessageBox.Show("nie podano liczb");
                }

            }
            else
                MessageBox.Show("nie podano wartości");
        }

        private void bNK_Click(object sender, EventArgs e)
        {
            double[] v = new double[] { 1.23, 1.08, 1.07, 1.05, 1 };
            double[] m = new double[] { 1.23, 1.08, 1.07, 1.05, 1 };
            if (textBoxNK.Text != "")
            {
                try
                {
                    var i = double.Parse(textBoxNK.Text);
                    var w = i * v[comboBoxNK.SelectedIndex] * m[comboBoxMNK.SelectedIndex];
                    w = Math.Round(w, 2);
                    textBoxWNK.Text = w.ToString();


                }
                catch
                {
                    MessageBox.Show("nie podano liczb");

                }


            }
            else
                MessageBox.Show("nie podano wartości");



        }

        private void bKO_Click(object sender, EventArgs e)
        {
            double[] v = new double[] { 1.23, 1.08, 1.07, 1.05, 1 };
            double[] m = new double[] { 1.23, 1.08, 1.07, 1.05, 1 };
            double[] o = new double[] { 1, 1.01, 1.02 };
            if (textBoxKO.Text != "")
            {
                try
                {
                    var i = double.Parse(textBoxKO.Text);
                    var w = i * v[comboBoxKO.SelectedIndex] * m[comboBoxMKO.SelectedIndex] * o[comboBoxOKO.SelectedIndex];
                    w = Math.Round(w, 2);
                    textBoxWKO.Text = w.ToString();

                }
                catch
                {

                    MessageBox.Show("nie podano liczb");
                }




            }
            else
                MessageBox.Show("nie podano wartości");

        }
    }
}


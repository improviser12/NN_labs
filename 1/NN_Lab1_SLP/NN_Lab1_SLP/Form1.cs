using System;
using System.Linq;
using System.Windows.Forms;

namespace NN_Lab1_SLP
{
    public partial class Form1 : Form
    {
        // variant 13
        private double a = 4;
        private double B = 2;
        private double d = 0.5;
        private static int p = 3;                   // number of input units
        private static int m = 100;
        private static int test_points = 20;
        private double h = 0.1;                     // how much x increase
        private double lr, deserror;                // the learning rate (alpha) and desired error
        private int L = m - p;                      // number of training samples

        double[] x = new double[m + test_points];
        double[] y = new double[m + test_points];   // desired points coordinates
        double[] yf = new double[m + test_points];  //real
        private double miny, maxy;
        private double[] y_oblicz = new double[m + test_points];

        Random rand = new Random();
        private double[] w = new double[p];
        private double[] w_oblicz = new double[p];
        private double t, t_oblicz;
        private double[] sqerror = new double[10000];   // depends on slp how much time it will learn

        public Form1()
        {
            InitializeComponent();

            GiveGraphic();
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = Getnum();
            }
            t = Getnum();

            tbrw1.Text = w[0].ToString();
            tbrw2.Text = w[1].ToString();
            tbrw3.Text = w[2].ToString();
            tbrt.Text = t.ToString();

        }

        public double Getnum()
        {
            int a = rand.Next(0, 2);
            if (a == 1)
            {
                return Math.Round(rand.NextDouble(), 5);        // from 0 to 1
            }
            else
            {
                return Math.Round((rand.NextDouble() * -1), 5); // from 0 to 1
            }
        }

        private void bLearn_Click(object sender, EventArgs e)
        {
            //learning
            listBox2.Items.Clear();
            if (tblearnrate.Text != null)
            {
                lr = Convert.ToDouble(tblearnrate.Text);
            }
            if (tbdeserror.Text != null)
            {
                deserror = Convert.ToDouble(tbdeserror.Text);
            }

            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();

            bool flag = false;
            int qty = 0;


            for (int i = p; (i < m) && (flag != true); i++)
            {
                int k = 0;
                for (int j = (i - p); j < i; j++)
                {
                    y_oblicz[i] = y_oblicz[i] * y[j] * w[k];
                    k++;
                }
                y_oblicz[i] += -t;
                //y_oblicz[i] -= t;
                k = 0;
                for (int j = (i - p); j < i; j++)
                {
                    w[k] = w[k] - lr * y[j] * (y_oblicz[i] - y[i]);
                    w_oblicz[k] = w[k];
                    k++;
                }

                t = t + lr * (y_oblicz[i] - y[i]);
                t_oblicz = t;
                sqerror[i - p] = (Math.Pow(y_oblicz[i] - y[i], 2)) / 2;

                y_oblicz[i] = Math.Round(y_oblicz[i], 3);
                t_oblicz = Math.Round(t_oblicz, 3);
                sqerror[i - p] = Math.Round(sqerror[i - p], 4);
                w[0] = Math.Round(w[0], 2);
                w[1] = Math.Round(w[1], 2);
                w[2] = Math.Round(w[2], 2);

                string txt = "X[" + (i - p).ToString() + "] = " + x[i - p].ToString() + ", Y[" + (i - p).ToString() + "]= " + y_oblicz[i - p].ToString() + ", T = " +
                    t_oblicz.ToString() + ", Es = " + sqerror[i - p].ToString() + ", W1 = " + w[0] +
                    ", W2 = " + w[1] + ", W3 = " + w[2];
                listBox2.Items.Add(txt);

                if (sqerror[i - p] <= deserror)
                {
                    flag = true;
                }

                qty++;
            }
            listBox2.Items.RemoveAt(listBox2.Items.Count - 1);

            for (int i = 0; i < p; i++)
            {
                this.chart1.Series[2].Points.AddXY(x[i], y[i]);
            }

            for (int i = p; i < (qty + 1); i++)
            {
                this.chart1.Series[2].Points.AddXY(x[i], y_oblicz[i]);
            }

            //testing
            for (int i = (qty - 1); i <= (qty + test_points); i++)
            {
                int k = 0;
                for (int j = (i - p); j < i; j++)
                {
                    y_oblicz[i] += y[i] * w_oblicz[k];
                    k++;
                }
                y_oblicz[i] += -t_oblicz;

                string txttest = "X[" + i.ToString() + "] = " + x[i].ToString() + ", Y[" + i.ToString() + "] = " + y_oblicz[i].ToString();
                listBox3.Items.Add(txttest);
            }

            for (int i = (qty - 1); i <= (qty + test_points); i++)
            {
                this.chart1.Series[3].Points.AddXY(x[i], y_oblicz[i]);
            }

        }

        public void GiveGraphic()
        {
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            for (int i = 0; i < (m + test_points); i++)
            {
                if (i != 0)
                {
                    x[i] = x[i - 1] + h;
                }
                else
                {
                    x[i] = 0;
                }

                y[i] = a * Math.Sin(B * x[i]) + d;
                this.chart1.Series[0].Points.AddXY(x[i], y[i]);
                x[i] = Math.Round(x[i], 3);
                y[i] = Math.Round(y[i], 3);
                string txt = "X[" + i.ToString() + "] = " + x[i].ToString() + ", Y[" + i.ToString() + "] = " + y[i].ToString();
                listBox1.Items.Add(txt);
            }

            miny = y.Min();
            maxy = y.Max();
            for (int i = 0; i < (m + test_points); i++)
            {
                yf[i] = ((y[i] - miny) * (1 - 0)) / (maxy - miny) + 0; // a = -0.6, b = 0.5
                this.chart1.Series[1].Points.AddXY(x[i], yf[i]);

                if (i < p)
                {
                    y_oblicz[i] = yf[i];
                }
            }
        }
    }
}

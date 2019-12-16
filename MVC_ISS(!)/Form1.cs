using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_ISS___
{
    public partial class Form1 : Form
    {
        public double X { get; set; }
        public double Y { get; set; }

        Controller controller;
        public FormMain(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            controller.OnError += ErrorMessage;
        }
        public void ErrorMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            X = Double.Parse(x);
        }
        private void txt_y_TextChanged(object sender, EventArgs e)
        {
            Y = Double.Parse(y);
        }
        private void txt_dist_aster2_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(L2);
        }
        private void txt_dist_to_aster1_TextChanged()
        {
            Model_ISS.Distance_to_aster1();
            Console.WriteLine(L1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            Bitmap iss = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(iss);
            Pen pen1 = new Pen(Color.Blue);
            Pen pen2 = new Pen(Color.Red);
            graph.DrawRectangle(pen1, X1, Y1, X4, Y4);
            DrawRectangle(pen2, X5, Y5, X6, Y6);
            picture.Image = iss;
        }

        private void list_output_date_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("All OK!");

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (controller.Create(txt_x.Text, txt_y.Text))
            {
                controller.Show();
            }
        }
    }
}

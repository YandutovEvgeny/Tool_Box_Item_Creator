using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonCreater
{
    public partial class Form1 : Form
    {
        Button[] buttons;
        PictureBox[] pictureBoxes;
        public Form1()
        {
            InitializeComponent();

        }
        void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //btn.BackColor = Color.Red;
            MessageBox.Show("Я кнопка " + btn.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            if(buttons != null)
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    panel1.Controls.Remove(buttons[i]);
                }
            }
            buttons = new Button[n];
            for (int i = 0; i < n; i++)
            {
                buttons[i] = new Button();
                buttons[i].Width = 50;
                buttons[i].Height = 50;
                buttons[i].Text = i.ToString();
                buttons[i].Top = 50;
                buttons[i].Click += button_Click;   //Привязываем клик по кнопке к методу button_Click
                buttons[i].Left = 52 * i + 5;
                buttons[i].BackColor = Color.LightGray;
                panel1.Controls.Add(buttons[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = trackBar1.Value;
            if(pictureBoxes != null)
            {
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    panel1.Controls.Remove(pictureBoxes[i]);
                }
            }
            pictureBoxes = new PictureBox[n];
            for (int i = 0; i < n; i++)
            {
                pictureBoxes[i] = new PictureBox();
                pictureBoxes[i].Width = 50;
                pictureBoxes[i].Height = 50;
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;
                string path = "c:\\Cards\\image_part_03" + i + ".jpg";
                pictureBoxes[i].Image = Bitmap.FromFile(path);
                pictureBoxes[i].Top = 100;
                pictureBoxes[i].Left = 102 * i + 5;
                panel1.Controls.Add(pictureBoxes[i]);
            }
        }
    }
}

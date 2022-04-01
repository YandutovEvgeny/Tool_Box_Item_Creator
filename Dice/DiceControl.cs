using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dice
{
    class DiceControl:PictureBox
    {
        Graphics graphics;
        Random random;
        public int Count { get; set; }  //Кол-во граней
        public Font NumberFont { get; set; }
        public Color NumberColor { get; set; }
        public DiceControl()
        {
            Width = 100;    //Ширина
            Height = 100;   //Высота
            graphics = CreateGraphics();
            graphics.Clear(Color.White);
            Count = 6;
            NumberFont = new Font("Arial", 20);
            NumberColor = Color.Black;
            random = new Random();
            DrawNumber(1);
        }
        void DrawNumber(int num)
        {
            int x = (int)Math.Round(NumberFont.Size / 2);
            graphics.Clear(Color.White);
            Bitmap bitmap = new Bitmap(Image.FromFile("c:\\cards\\1.jpg"), Width, Height);
            graphics.DrawImage(bitmap, 0, 0);
            graphics.DrawString
            (
                num.ToString(), 
                NumberFont, 
                new SolidBrush(NumberColor), 
                Width/2 - x, 
                Height/2 - x
            );
        }
        public void Generate()
        {
            DrawNumber(random.Next(Count) + 1);
        }
    }
}

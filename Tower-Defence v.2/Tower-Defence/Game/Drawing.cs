using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;


namespace Tower_Defence
{
    public static class Drawing
    {
        public static Graphics picBoxCanvas;
        public static Graphics logicsCanvas;
        public static Bitmap imageCanvas;
        public static int a = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width/45;
        public static Color color;
        public static Brush brush;
        public static Font font;


        public static void DrawField()
        {
            //logicsCanvas.FillRectangle(Brushes.DarkGray, 0, 0, imageCanvas.Width, imageCanvas.Height);
            logicsCanvas.FillRectangle(Brushes.LightYellow, a, a, imageCanvas.Width - a * 2, imageCanvas.Height - a * 2);
            for (int i = 0; i < Map.getInstance().xX; i++)
                for (int j = 0; j < Map.getInstance().yY; j++)
                {
                    if (Map.getInstance().field[i, j].edge == true)
                        logicsCanvas.FillRectangle(Brushes.DarkGray, i * a, j * a, a, a);
                    if (Map.getInstance().field[i, j].flag == true)
                        logicsCanvas.DrawRectangle(new Pen(Color.Green,3), i * a, j * a, a, a);
                }
        }
        public static void DrawAttack()
        {
            for (int i = 0; i < 50; i++)
                for (int j = 0; j < 20; j++)
                {
                    if (Map.getInstance().field[i, j].obj is Tower)
                    {
                        if(Map.getInstance().field[i, j].obj.target != null)
                        {
                            //for (int n = i * a + 5; i < Map.getInstance().field[i, j].obj.target.X * a + 15; i = i + Convert.ToInt32(Math.Abs(Map.getInstance().field[i, j].obj.target.X * a- i * a)/5))
                             //   for (int m = j * a + 5; m < Map.getInstance().field[i, j].obj.target.Y * a + 15; j = j + Convert.ToInt32(Math.Abs(Map.getInstance().field[i, j].obj.target.X * a - i * a) / 5))
                             //   {
                             //   logicsCanvas.FillEllipse(Brushes.Black, i,)
                            //}
                        }
                    }
                }
        }
        public static void DrawUnits(bool check,bool checkPass, bool grid)
        {
            font = new Font("Arial", 11);
            for (int i = 0; i < Map.getInstance().xX; i++)
                for (int j = 0; j < Map.getInstance().yY; j++)
                {
                    //logicsCanvas.DrawRectangle(Pens.Black, i * a, j * a , a, a);
                    //logicsCanvas.FillRectangle(Brushes.Red, i*a+12, j*a+12, 15, 15);
                    //logicsCanvas.DrawString(Convert.ToString(i), font, Brushes.Black, a * i, a * j);
                    if ((Map.getInstance().field[i, j].pass == false) & (checkPass)) logicsCanvas.FillRectangle(Brushes.Aqua, a * i, a * j, a, a);
                    else
                    {
                        if (Map.getInstance().field[i, j].obj != null)
                        {
                            if (Map.getInstance().field[i, j].obj.enemy == true)
                            {
                                if (Map.getInstance().field[i, j].obj is Tower)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"RedTower.png"), a * i+1, a * j - a+1);
                                    logicsCanvas.FillRectangle(Brushes.LightYellow, a * i, a * j + a, a, a);
                                    logicsCanvas.DrawString(Convert.ToString(Map.getInstance().field[i, j].obj.hp), font, Brushes.Black, a * i + 2, a * j + a);
                                    if (check) logicsCanvas.FillRectangle(Brushes.Red, a * i, a * j, a, a);
                                }
                                if (Map.getInstance().field[i, j].obj is Castle)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"RedCastle.png"), a * i - a, a * j - a*2);
                                    logicsCanvas.FillRectangle(Brushes.LightYellow, a * i, a * j + a, a, a);
                                    logicsCanvas.DrawString(Convert.ToString(Map.getInstance().field[i, j].obj.hp), font, Brushes.Black, a * i - 5, a * j + a);
                                    if (check) logicsCanvas.FillRectangle(Brushes.Red, a * i, a * j, a, a);
                                }
                                if (Map.getInstance().field[i, j].obj is Melee)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"RedMelee.png"), a * i, a * j);
                                    //logicsCanvas.DrawLine(new Pen(Color.Green, 3), a*i+a,a*j+a,a*i+a,a*j+a);
                                }
                                if (Map.getInstance().field[i, j].obj is Range)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"RedRange.png"), a * i, a * j);
                                }
                                if (Map.getInstance().field[i, j].obj is Ballista)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"RedBallista.png"), a * i, a * j);
                                }
                                
                            }
                            else
                            {
                                if (Map.getInstance().field[i, j].obj is Tower)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"BlueTower.png"), a * i+1, a * j - a+1);
                                    logicsCanvas.FillRectangle(Brushes.LightYellow, a * i + 2, a * j + a, a, a);
                                    logicsCanvas.DrawString(Convert.ToString(Map.getInstance().field[i, j].obj.hp), font, Brushes.Black, a * i + 2, a * j + a);
                                    if (check) logicsCanvas.FillRectangle(Brushes.Blue, a * i, a * j, a, a);
                                }
                                if (Map.getInstance().field[i, j].obj is Castle)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"BlueCastle.png"), a * i - a, a * j - a*2);
                                    logicsCanvas.FillRectangle(Brushes.LightYellow, a * i, a * j + a, a, a);
                                    logicsCanvas.DrawString(Convert.ToString(Map.getInstance().field[i, j].obj.hp), font, Brushes.Black, a * i - 5, a * j + a);
                                    if (check) logicsCanvas.FillRectangle(Brushes.Blue, a * i, a * j, a, a);
                                }
                                if (Map.getInstance().field[i, j].obj is Melee)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"BlueMelee.png"), a * i, a * j);
                                }
                                if (Map.getInstance().field[i, j].obj is Range)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"BlueRange.png"), a * i, a * j);
                                }
                                if (Map.getInstance().field[i, j].obj is Ballista)
                                {
                                    logicsCanvas.DrawImage(Image.FromFile(@"BlueBallista.png"), a * i, a * j);
                                }
                                
                            }
                        }
                    }
                    if (grid == true) logicsCanvas.DrawRectangle(Pens.Black, i * a, j * a, a, a);
                }
            //picBoxCanvas.DrawImage(imageCanvas, 0, 0);
        }
        public static void MainDrawingMethod(bool checkObj,bool checkPass, bool grid)
        {
            logicsCanvas.Clear(Color.White);
            DrawField();
            DrawUnits(checkObj,checkPass,grid);
            picBoxCanvas.DrawImage(imageCanvas, 0, 0);
        }
        public static void Round(int x, int y)
        {
            for (int i = 0; i < 8; i++)
            {
                logicsCanvas.FillRectangle(Brushes.Red, a * Map.getInstance().field[x, y].related[i].X, a * Map.getInstance().field[x, y].related[i].Y, a, a);
            }
            picBoxCanvas.DrawImage(imageCanvas, 0, 0);
        }
    }
}

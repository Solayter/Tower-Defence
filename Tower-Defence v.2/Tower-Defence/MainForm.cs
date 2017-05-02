using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;



namespace Tower_Defence
{
    public partial class MainForm : Form
    {
        public Gameplay game = new Gameplay();
        public Map map = Map.getInstance();
        public int a = 10, b = 10;
        public int level = 1;
        public int radio;
        public Cell chosenCell;
        public bool unitBool = false;
        public bool activate = false;
        public int click = Screen.PrimaryScreen.Bounds.Width / 45;
        
        public MainForm()
        {
            InitializeComponent();

            picBox.Location = new Point(200, 0);
            picBox.Height = (Screen.PrimaryScreen.Bounds.Width / 60) * 20;
            picBox.Width = (Screen.PrimaryScreen.Bounds.Width / 60) * 50;

            Drawing.picBoxCanvas = picBox.CreateGraphics();
            Drawing.imageCanvas = new Bitmap(picBox.ClientRectangle.Width, picBox.ClientRectangle.Height);
            Drawing.logicsCanvas = Graphics.FromImage(Drawing.imageCanvas);

            Width = (Screen.PrimaryScreen.Bounds.Width / 60) * 50 + 220;
            Height = Convert.ToInt32((Screen.PrimaryScreen.Bounds.Width / 60) * 21.5);

            redBut.Visible = false;
            blueBut.Visible = false;

            gridCheck.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picBox.Enabled = true;
            startBut.Visible = false;
            redBut.Visible = true;
            blueBut.Visible = true;
            loadBut.Enabled = true;
            saveBut.Enabled = true;
            map.BuildField();
            Drawing.MainDrawingMethod(buildCheck.Checked,passCheck.Checked,gridCheck.Checked);
            timer_for_action.Enabled = true;
            timer_for_drawing.Enabled = true;
            timer_for_spawn.Enabled = true;
            
        }

        private void timer_for_action_Tick(object sender, EventArgs e)
        {
            Thread gaming = new Thread(param =>
            {
                game.Process();
            }
            );
            gaming.Start();
            Drawing.MainDrawingMethod(buildCheck.Checked, passCheck.Checked, gridCheck.Checked);
            
        }

        private void timer_for_drawing_Tick(object sender, EventArgs e)
        {

            Drawing.MainDrawingMethod(buildCheck.Checked, passCheck.Checked, gridCheck.Checked);
        }
        
        private void picBox_MouseClick(object sender, MouseEventArgs e)
        {
            int a = Screen.PrimaryScreen.Bounds.Width / 45;
            if (e.Button == MouseButtons.Left)
            {
                if (chosenCell != null)
                {
                    chosenCell.flag = false;
                }
                chosenCell = map.field[Convert.ToInt32(Convert.ToDecimal(e.X / click)), Convert.ToInt32(Convert.ToDecimal(e.Y / click))];
                chosenCell.X = Convert.ToInt32(Convert.ToDecimal(e.X / click));
                chosenCell.Y = Convert.ToInt32(Convert.ToDecimal(e.Y / click));
                chosenCell.flag = true;
                //Drawing.Round(chosenCell.X, chosenCell.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (chosenCell.obj != null)
                {
                    if(map.field[Convert.ToInt32(Convert.ToDecimal(e.X / click)), Convert.ToInt32(Convert.ToDecimal(e.Y / click))].obj != null)
                    {
                        chosenCell.obj.target = map.field[Convert.ToInt32(Convert.ToDecimal(e.X / click)), Convert.ToInt32(Convert.ToDecimal(e.Y / click))].obj;
                    }
                    else
                    {
                        chosenCell.obj.point.X = Convert.ToInt32(Convert.ToDecimal(e.X / click));
                        chosenCell.obj.point.Y = Convert.ToInt32(Convert.ToDecimal(e.Y / click));
                    }
                }
            }
        }
        
        private void blueBut_Click(object sender, EventArgs e)
        {
            blueBut.BackColor = Color.LightGray;
            redBut.BackColor = Color.Red;
            blueBut.Enabled = false;
            redBut.Enabled = true;
            unitBool = false;
            activate = true;
            picMelee.Image = Image.FromFile(@"BlueMelee.png");
            picRange.Image = Image.FromFile(@"BlueRange.png");
            picBal.Image = Image.FromFile(@"BlueBallista.png");
        }

        private void redBut_Click(object sender, EventArgs e)
        {
            redBut.BackColor = Color.LightGray;
            blueBut.BackColor = Color.Blue;
            redBut.Enabled = false;
            blueBut.Enabled = true;
            unitBool = true;
            activate = true;
            picMelee.Image = Image.FromFile(@"RedMelee.png");
            picRange.Image = Image.FromFile(@"RedRange.png");
            picBal.Image = Image.FromFile(@"RedBallista.png");
        }

        private void spawnMelee_but_Click(object sender, EventArgs e)
        {
            if ((chosenCell != null) & activate)
                if ((chosenCell.obj == null) & chosenCell.pass)
                {
                    game.SpawnMelee(unitBool,chosenCell.X, chosenCell.Y);
                }
        }

        private void spawnRange_but_Click(object sender, EventArgs e)
        {
            if ((chosenCell != null) & activate)
                if ((chosenCell.obj == null) & chosenCell.pass)
                {
                    game.SpawnRange(unitBool,chosenCell.X, chosenCell.Y);
                }
        }

        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "Game " + e.X +" "+ e.Y;
        }

        private void spawnBal_Click(object sender, EventArgs e)
        {
            if ((chosenCell != null) & activate)
                if ((chosenCell.obj == null) & chosenCell.pass)
                {
                    game.SpawnBallista(unitBool, chosenCell.X, chosenCell.Y);
                }
        }

        
        private void saveBut_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            if (file.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = file.FileName;
            File.WriteAllText(filename, Memento.SaveFile());
        }

        private void loadBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                Memento.OpenFile(file.FileName);
            }
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void timer_for_spawn_Tick(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void picBox_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WMPLib;
using System.Threading;
namespace Puzzle
{
    public partial class Form1 : Form
    {
        Thread th;
        System.Timers.Timer t;
        int m, s, ms;
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "music.mp3";
           
        }
        OpenFileDialog openFileDialog = null;
        Image image;
        Image pic;
        PictureBox picBoxWhole = null;
        PictureBox originalpic = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();//CreatedATimer
            t.Interval = 10;               //interval for msec
            t.Elapsed += OnTimeEvent;   // Hook up the Elapsed event for the timer
            player.controls.play();  //playingBGmusic
            pause.Hide();
        }
        public void Stop()
        {
            
            bool y = isSuccessful();
                Form2 f2 = new Form2(y);
                t.Stop();
                player.controls.stop();
                f2.Show();
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                    }
        private void opennewform()
        {
     
            bool y = isSuccessful();
            player.controls.stop();
            Application.Run(new Form2(y));
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 60)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                    { if (currentLevel == 4) Stop(); }
                    { if (currentLevel == 9) Stop(); }
                    { if (currentLevel == 16 && m == 2) Stop(); }
                }
                textBox1.Text = string.Format("{0}:{1}:{2}", m.ToString().PadLeft(2, '0'),
               s.ToString().PadLeft(2, '0'), ms.ToString().PadLeft(2, '0'));
                if(s==50 &&( currentLevel == 4 ||currentLevel==9))
                {
                    textBox1.ForeColor = Color.Red;
                }
                if (m == 1 && s == 50 && currentLevel == 16)
                {
                    textBox1.ForeColor = Color.Red;
                }
            }
                ));
        }
        private void buttonImageBrowse_Click_1(object sender, EventArgs e)
        {
            
            if (openFileDialog == null)
                openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = CreateBitmapImage(Image.FromFile(openFileDialog.FileName));
                if (picBoxWhole == null)
                {
                    picBoxWhole = new PictureBox();
                    picBoxWhole.Height = groupboxPuzzle.Height;
                    picBoxWhole.Width = groupboxPuzzle.Width;
                    groupboxPuzzle.Controls.Add(picBoxWhole);
                }
                picBoxWhole.Image = image;

                pic = CreateBitmapPicture(Image.FromFile(openFileDialog.FileName));
                if (originalpic == null)
                {
                    originalpic = new PictureBox();
                    originalpic.Height = realPic.Height;
                    originalpic.Width = realPic.Width;
                    realPic.Controls.Add(originalpic);
                }
                originalpic.Image = pic;
            }
        }
        private Bitmap CreateBitmapImage(Image image)

        {
            Bitmap objBmpImage = new Bitmap(groupboxPuzzle.Width, groupboxPuzzle.Height);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.DrawImage(image, new Rectangle(0, 0, groupboxPuzzle.Width, groupboxPuzzle.Height));
            objGraphics.Flush();
            return objBmpImage;
        }
        private Bitmap CreateBitmapPicture(Image image)
        {
            Bitmap objBmpImage = new Bitmap(realPic.Width, realPic.Height);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.DrawImage(image, new Rectangle(0, 0, realPic.Width, realPic.Height));
            objGraphics.Flush();
            return objBmpImage;
        }


        PictureBox[] picBoxes = null;
        Image[] images = null;
        const int LEVEL_1_NUM = 4;
        int currentLevel = 0;
        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            if (picBoxWhole != null)
            {
                t.Start();
                currentLevel = LEVEL_1_NUM;
                NewMethod();
            }
        }
        private void NewMethod()
        {
            if (picBoxWhole != null)
            {
                groupboxPuzzle.Controls.Remove(picBoxWhole);
                picBoxWhole.Dispose();
                picBoxWhole = null;
            }
            if (picBoxes == null)
            {
                images = new Image[currentLevel];
                picBoxes = new PictureBox[currentLevel];
            }
            int nunRow = (int)Math.Sqrt(currentLevel);
            int nunCol = nunRow;
            int unitX = groupboxPuzzle.Width / nunRow;
            int unitY = groupboxPuzzle.Height / nunCol;
            int[] indice = new int[currentLevel];
            for (int i = 0; i < currentLevel; i++)
            {
                indice[i] = i;
                if (picBoxes[i] == null)
                {
                    picBoxes[i] = new MyPictureBox();
                    picBoxes[i].Click += new EventHandler(OnPuzzleClick);
                    picBoxes[i].BorderStyle = BorderStyle.Fixed3D;
                }
                picBoxes[i].Width = unitX;
                picBoxes[i].Height = unitY;
                ((MyPictureBox)picBoxes[i]).Index = i;
                CreateBitmapImage(image, images, i, nunRow, nunCol, unitX, unitY);
                picBoxes[i].Location = new Point(unitX * (i % nunCol), unitY * (i / nunCol));
                if (!groupboxPuzzle.Controls.Contains(picBoxes[i]))
                    groupboxPuzzle.Controls.Add(picBoxes[i]);
            }
            shuffle(ref indice);
            for (int i = 0; i < currentLevel; i++)
            {
                picBoxes[i].Image = images[indice[i]];
                ((MyPictureBox)picBoxes[i]).ImageIndex = indice[i];
            }
        }
        private void CreateBitmapImage(Image image, Image[] images,
            int index, int numRow, int numCol, int unitX, int unitY)
        {
            images[index] = new Bitmap(unitX, unitY);
            Graphics objGraphics = Graphics.FromImage(images[index]);
            objGraphics.DrawImage(image,
            new Rectangle(0, 0, unitX, unitY),
            new Rectangle(unitX * (index % numCol), unitY * (index / numCol), unitX, unitY),
            GraphicsUnit.Pixel);
            objGraphics.Flush();
        }
        private void shuffle(ref int[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                int temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
        MyPictureBox firstBox = null;
        MyPictureBox secondBox = null;

        public void OnPuzzleClick(object sender, EventArgs e)
        {
            if (firstBox == null)
            {
                firstBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.FixedSingle;
               
            }
            else if (secondBox == null)
            {
                secondBox = (MyPictureBox)sender;
                firstBox.BorderStyle = BorderStyle.Fixed3D;
             
                secondBox.BorderStyle = BorderStyle.FixedSingle;
                SwitchImages(firstBox, secondBox);
                firstBox = null;
                secondBox = null;
            }
        }
        private void SwitchImages(MyPictureBox box1, MyPictureBox box2)
        {
            int tmp = box2.ImageIndex;
            box2.Image = images[box1.ImageIndex];
            box2.ImageIndex = box1.ImageIndex;
            box1.Image = images[tmp];
            box1.ImageIndex = tmp;
            if (isSuccessful())
            {
                Stop();
            }
        }
        private bool isSuccessful()
        {
            for (int i = 0; i < currentLevel; i++)
            {
                if (((MyPictureBox)picBoxes[i]).ImageIndex != ((MyPictureBox)picBoxes[i]).Index)
                    return false;
            }
            return true;
        }
        private const int LEVEL_2_NUM = 9;
        private void buttonLevel2_Click(object sender, EventArgs e)
        {
            if (picBoxWhole != null)
            {
                t.Start();
                currentLevel = LEVEL_2_NUM;
                NewMethod();
            }
        }
        private const int LEVEL_3_NUM = 16;
        private void buttonLevel3_Click(object sender, EventArgs e)
        {
            if (picBoxWhole != null)
            {
                t.Start();
                currentLevel = LEVEL_3_NUM;
                NewMethod();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
                Form3 f3 = new Form3();
                f3.Show();
            
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void platBtn_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
        }

        private void muteBtn_Click(object sender, EventArgs e)
        {
            player.controls.stop();

        }

        private void pauseBtn_Click_1(object sender, EventArgs e)
        {
            if (picBoxes != null)
            {
                t.Stop();
                pause.Show();
            }
        }

        private void playBtn_Click_1(object sender, EventArgs e)
        {
            if (picBoxes != null)
                t.Start();
            pause.Hide();

        }

        private void soundBtn_Click_1(object sender, EventArgs e)
        {
            player.controls.play();

        }    
        private void groupBox3_Enter(object sender, EventArgs e)
    {

    }
}
}
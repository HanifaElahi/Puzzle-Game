using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Puzzle
{
    public partial class Form2 : Form
    {
        bool m;
      
        WindowsMediaPlayer player = new WindowsMediaPlayer();
       

        public Form2(bool y)
        {
            InitializeComponent();
            m = y;
           
            player.URL = "gameOver.mp3";
             youloseBox.Hide(); 

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            player.controls.play();
           
            if (m!=true)
            {
                welldoneBox.Hide();
                youloseBox.Show();
                myPictureBox1.Hide();
              
            }
        }

        private void again_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

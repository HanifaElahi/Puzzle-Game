using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    class MyPictureBox : PictureBox
    {
        int index = 0;
        public int Index { get => index; set => index = value; }

        int imageIndex = 0;
        public int ImageIndex{get=>imageIndex;set=>imageIndex=value;}
        public bool isSuccessful()
        {
            return (index == imageIndex);
        }
       

    }
}

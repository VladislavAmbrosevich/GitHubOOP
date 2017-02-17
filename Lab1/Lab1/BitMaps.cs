﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1
{
    public class BitMaps
    {
        public BitMaps()
        {
            Size = 0;
            // ChoosenIndex = 0;
        }
        public void DrawAll(PictureBox pbox)
        {
            //for (int i = 0; i < Size; i++)
                //Layers[i].Draw(pbox);
        }


        public Bitmap this[int index]
        {
            get { return Layers[index]; }
            set { Layers[index] = value; if (index >= Size) Size++; }
        }
        private Bitmap[] Layers = new Bitmap[100];
        public int Size { get; set; }
        //public int ChoosenIndex { get; set; }
    }
}

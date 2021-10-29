using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment2
{
    public class Rectangle
    {
        private int height;
        private int width;
        private int length;

        public Rectangle()
        {
            height = 1;
            width = 1;
            length = 1;
        }

        public Rectangle(int len,int h, int wid)
        {
            height = h;
            width = wid;
            length = len;
        }
        public int GetLength() {
            return length;
        }
        public int SetLength(int length) {
            if (length > 0)
            {
                this.length = length;
                return this.length;
            }
            else
                return 0;
        }
        public int GetWidth() {
            return width;
        }
        public int SetWidth(int width) {
            if (width > 0)
            {
                this.width = width;
                return width;
            }
            else
                return 0;
        }
        public int GetHeight() {
            return height;
        }
        public int SetHeight(int height) {
            if (height > 0)
            {
                this.height = height;
                return this.height;
            }
            else
                return 0;
        }
        public int GetVolume() {
            return height*width*length;
        }
    }
}

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
            this.length = length;
            return this.length;
        }
        public int GetWidth() {
            return width;
        }
        public int SetWidth(int width) {
            this.width = width;
            return width;
        }
        public int GetHeight() {
            return this.height;
        }
        public int SetHeight(int height) {
            this.height = height;
            return this.height;
        }
        public int GetVolume() {
            return 1;
        }
    }
}

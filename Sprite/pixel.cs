using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite
{
    public class pixel
    {
        private int x;
        private int y;
        private Color color;
        private int palleteindex;

        public pixel(int x, int y, Color color)
        {
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }

        public Color getColor()
        {
            return this.color;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setColor(Color Color)
        {
            this.color = Color;
        }

        public void setPalleteindex(int index)
        {
            this.palleteindex = index;
        }
        public int getPalleteindex()
        {
            return this.palleteindex;
        }
    }
}

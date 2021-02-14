using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace snake
{
    class yilan
    {
        /// <summary>
        /// ////////////////////////////////
        /// </summary>
        parca[] yilan_parca;
        int yilan_size;
        yon yonumuz;
        public yilan()
        {
            yilan_parca = new parca[3];
            yilan_size = 3;
            yilan_parca[0] = new parca(150, 150);
            yilan_parca[1] = new parca(160, 150);
            yilan_parca[2] = new parca(170, 150);
        }
        public void ilerle(yon yon)
        {
            yonumuz = yon;
            if (yon._x == 0 && yon._y == 0)
            {

            }
            else
            {
                for (int i = yilan_parca.Length - 1; i > 0; i--)
                {
                    yilan_parca[i] = new parca(yilan_parca[i - 1].x_, yilan_parca[i - 1].y_);

                }
                yilan_parca[0] = new parca(yilan_parca[0].x_ + yon._x, yilan_parca[0].y_ + yon._y);

            }

        }
        public void buyu()
        {
            Array.Resize(ref yilan_parca, yilan_parca.Length + 1);
            yilan_parca[yilan_parca.Length - 1] = new parca(yilan_parca[yilan_parca.Length - 2].x_ - yonumuz._x, yilan_parca[yilan_parca.Length - 2].y_ - yonumuz._y);
            yilan_size++;
        }
        public Point GetPos(int number)
        {
            return new Point(yilan_parca[number].x_, yilan_parca[number].y_);
        }
        public int Yilan_size
        {
            get
            {
                return yilan_size;
            }
        }
            

    }
    class parca
    {
        public  int x_;
        public  int y_;
        public readonly int size_x;
        public readonly int size_y;
        
        
        public parca (int x, int y)
        {
            x_ = x;
            y_ = y;
            size_x = 10;
            size_y = 10;
        }
    }
    class yon
    {
        public int _x;
        public int _y;
        public yon (int x, int y)
        {
            _x = x;
            _y = y;
        }

    }
}

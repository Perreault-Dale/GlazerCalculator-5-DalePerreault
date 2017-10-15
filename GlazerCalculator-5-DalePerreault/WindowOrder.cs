using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazerCalculator_5_DalePerreault
{
    class WindowOrder
    {
        // class members
        public double width;
        public double height;
        public DateTime orderDate;
        public string tint;
        public int quantity;

        // constructor
        public WindowOrder(double wide, double high, string color, int amt)
        {
            width = wide;
            height = high;
            orderDate = DateTime.Now;
            tint = color;
            quantity = amt;
        }

        public double calcWoodLength(WindowOrder window)
        {
            return (window.height + window.width) * 3.25 * 2;
        }

        public double calcGlassArea(WindowOrder window)
        {
            return 2 * window.height * window.width;
        }
    }
}

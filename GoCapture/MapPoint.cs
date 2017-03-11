using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoCheck
{
    public class MapPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CellStatus CellStatus { get; set; }

        public MapPoint(int x, int y, CellStatus cellStatus)
        {
            X = x;
            Y = y;
            CellStatus = cellStatus;
        }
    }
}

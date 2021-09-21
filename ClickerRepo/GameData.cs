using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerRepo
{
    public class GameData
    {
        public int Cash { get; set; }
        public int Value { get; set; }
        public int Min { get; set; }
        public int Min2 { get; set; }

        public GameData(int yourCash, int dollarValue, int min, int min2)
        {
            Cash = yourCash;
            Value = dollarValue;
            Min = min;
            Min2 = min2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollBackIntegerProject
{
    class RollBackInteger
    {
        private int lastValue;
        private int currentValue;
        public int Value
        {
            set
            {
                lastValue = currentValue;
                currentValue = value;
            }
            get { return currentValue;}
        }

        public RollBackInteger(int value)
        {
            Value = value;
        }

        public void RollBack()
        {
            int t = lastValue;
            lastValue = currentValue;
            currentValue = t;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Quantum_Leap_Zack_Taylor.LeapComponents
{
    class Budget
    {
        private int _budget { get; set; }

        public Budget()
        {
            _budget = 3000;
        }

        public bool CheckBudget()
        {
            if (_budget < 1000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddFunds()
        {
            _budget += 5000;
        }
    }
}

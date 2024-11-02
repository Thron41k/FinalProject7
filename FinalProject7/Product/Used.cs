using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject7.Product
{
    internal class Used(bool afterRenavation, int monthsInUse, short state)
    {
        public bool AfterRenavation { get; } = afterRenavation;
        public int MonthsInUse { get; } = monthsInUse;
        public short State { get; } = state;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_IComparable_StephanieLopez
{
    internal class Potency : IComparer<Creature>
    {
        public enum SortingOrder { Ascending, Descending };
        public SortingOrder Sorting;

        public Potency()
        {
            Sorting = SortingOrder.Ascending;
        }

        public Potency(SortingOrder sorting)
        {
            Sorting = sorting;
        }

        public int Compare(Creature x, Creature y)
        {
            if (Sorting == SortingOrder.Ascending)
            {
                return x.Potency_.CompareTo(y.Potency_) * -1;
            }
            else
            {
                return x.Potency_.CompareTo(y.Potency_);
            }
        }
    }
}

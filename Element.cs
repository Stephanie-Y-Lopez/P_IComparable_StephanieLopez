using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_IComparable_StephanieLopez
{
    internal class Element : IComparer<Creature>
    {
        public enum SortingOrder { Ascending, Descending };
        public SortingOrder Sorting;

        public Element()
        {
            Sorting = SortingOrder.Ascending;
        }

        public Element(SortingOrder sorting)
        {
            Sorting = sorting;
        }

        public int Compare(Creature x, Creature y)
        {
            if (Sorting == SortingOrder.Ascending)
            {
                return x.Element.CompareTo(y.Element) * -1;
            }
            else
            {
                return x.Element.CompareTo(y.Element);
            }
        }
    }
}

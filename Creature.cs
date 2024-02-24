using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_IComparable_StephanieLopez
{
    public class Creature : IComparable<Creature>
    {
        //Fields
        public string _Type;
        public string _Element;
        public double _Potency;

        //Constructor
        public Creature(string type, string element)
        {
            _Type = type;
            _Element = element;
            Random Rand = new Random();
            _Potency = Rand.Next(0, 1000); //This stands for the amount of damage it can do between this range. 
        }

        //Properties
        public string Type { get => _Type; set => _Type = value; }
        public string Element { get => _Element; set => _Element = value; }
        public double Potency_ { get => _Potency; set => _Potency = value; }

        public int CompareTo(Creature other)
        {
            return _Type.CompareTo(other.Type);
            //The field I chose to sort by is the creature type, in descending order.
        }

        public override string ToString()
        {
            return $"Creature Type: {_Type} - Element Type: {_Element} - Potency Level: {_Potency}";
        }
    }
}

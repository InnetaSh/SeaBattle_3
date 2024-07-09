using SeaBattle_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle_3
{
    internal class ShipBase
    {
        public List<Decker> Deckers { get; set; }
        public static int ShipCount = 0;
        public bool isHorizontal;

        
        public ShipBase()
        {
            Deckers = new List<Decker>();
        }
        
    }
}


internal class SingleDeckShip :ShipBase
{

    public SingleDeckShip() : base() 
    {
        ShipCount++;
        Deckers.Add(new Decker());
    }
}

internal class DoubleDeckerShip : ShipBase
{

    public DoubleDeckerShip() : base()
    {
        ShipCount++;
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
    }
}

internal class ThreeDeckerShip : ShipBase
{

    public ThreeDeckerShip() : base()
    {
        ShipCount++;
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
    }
}

internal class FourDeckerShip : ShipBase
{

    public FourDeckerShip() : base()
    {
        ShipCount++;
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
        Deckers.Add(new Decker());
    }
}
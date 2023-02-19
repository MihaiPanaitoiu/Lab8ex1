using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    class VagonClasaIntai: VagonDePersoane
    {
        public VagonClasaIntai(int anulFabricatiei, int masa, int nrLocuri) : base(anulFabricatiei, masa, nrLocuri)
        {

        }

        public void pornesteAC()
        {
            Console.WriteLine("Aerul conditionat a fost pornit");
        }

        public void OpresteAC()
        {
            Console.WriteLine("Aerul conditionat a fost oprit");
        }
    }
}

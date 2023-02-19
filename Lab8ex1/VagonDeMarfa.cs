using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    class VagonDeMarfa : Vagon
    {
        private int capacitate;
        private TipMarfa tipMarfa;

        public VagonDeMarfa(int anulFabricatiei, int masa, int capacitate, TipMarfa tipMarfa):base(anulFabricatiei, masa)
        {
            this.capacitate = capacitate;
            this.tipMarfa = tipMarfa;
        }

        public TipMarfa TipMarfa { get { return this.tipMarfa; } }
        public int Capacitate { get { return this.capacitate; } }
    }
}

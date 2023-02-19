using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    class VagonDePersoane : Vagon
    {
        private int nrLocuri;
        public VagonDePersoane(int anulFabricatiei, int masa, int nrLocuri) : base(anulFabricatiei, masa)
        {
            this.nrLocuri = nrLocuri;
        }

        public void DeschideUsile()
        {
            Console.WriteLine("Usile s-au deschis");
        }

        public void InchideUsile()
        {
            Console.WriteLine("Usile s-au inchis");
        }
    }
}

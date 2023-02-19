using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8ex1
{
    class Tren
    {
        private string nume;
        private Locomotiva locomotiva;
        private List<Vagon> vagoane = new List<Vagon>();
        public Tren(string nume, Locomotiva locomotiva)
        {
            this.nume = nume;
            this.locomotiva = locomotiva;
        }

        public void AdaugaVagon(Vagon vagon)
        {
            vagoane.Add(vagon);
        }

        public void PleacaDinGara()
        {
            foreach(Vagon vagon in vagoane)
            {
                if (vagon is VagonClasaIntai)
                {
                    VagonClasaIntai vagonClasaIntai = vagon as VagonClasaIntai;
                    vagonClasaIntai.InchideUsile();
                    vagonClasaIntai.pornesteAC();
                } else if (vagon is VagonDePersoane)
                {
                    VagonDePersoane vagonDePersoane = vagon as VagonDePersoane;
                    vagonDePersoane.InchideUsile();
                }
            }
            locomotiva.Pornire();
        }

        public void OpresteInGara()
        {
            locomotiva.Opreste();

            foreach (Vagon vagon in vagoane)
            {
                if (vagon is VagonClasaIntai)
                {
                    VagonClasaIntai vagonClasaIntai = vagon as VagonClasaIntai;
                    vagonClasaIntai.OpresteAC();
                    vagonClasaIntai.DeschideUsile();
                }
                else if (vagon is VagonDePersoane)
                {
                    VagonDePersoane vagonDePersoane = vagon as VagonDePersoane;
                    vagonDePersoane.DeschideUsile();
                }
            }
        }
    }
}

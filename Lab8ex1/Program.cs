﻿using System;

namespace Lab8ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercitiu
• Un tren este compus din: o locomotiva si mai multe tipuri de vagoane.
 Locomotiva va avea
 O metoda de pornire, la apelul careia, aceasta va confirma faptul ca a pornit printr-un mesaj afisat in consola,
 O metoda de oprire, la apelul careia, aceasta va confirma faptul ca a oprit printr-un mesaj afisat in consola,
 Vagoanele vor avea masa si anul fabricatiei si vor fi de mai multe tipuri
 Vagoane de marfa, care vor avea
 tipul marfii (cereale/carbuni/otel) precum si capacitatea in tone
 Vagoane pentru persoane, care vor avea
 numar de locuri
 O metoda care va inchide usile si va confirma in consola inchiderea usilor
 O metoda care va deschide usile si va confirma in consola deschiderea usilor
 Vagoane clasa I, pentru persoane
 O metoda de pornire a aerului conditionat care va afisa acest lucru pe ecran
 O metoda de oprire a aerului conditionat care va afisa acest lucru pe ecran
• Trenul va avea un nume precum si urmatoarele metode
 Adauga vagon
 Aceasta metoda va permite adaugarea vagoanelor la tren
 Pleaca din gara
 La aceasta comanda, trenul va inchide usile vagoanelor de persoane si va porni locomotiva
 Opreste in gara
 La aceasta comanda, trenul va opri locomotiva, va deschide usile vagoanelor de persoane si va opri aerul conditionat in vagoanele clasa 1
Proiectati clasele, initializati un tren, adaugati-i vagoane si apelati metodele.
Suplimentar
Trenul va avea urmatoarele metode/proprietati
 NumarDeLocuri
 metoda/proprietate al carei apel va returna numarul total de locuri din vagoanele de
persoane precum si cele de clasa 1.
 SumarMarfa:
 metoda/proprietate al carei apel va returna o lista ce va contine capacitatea totala
corespunzatoare fiecarei categorii de marfa.
Proiectati clasele, initializati un tren, adaugati-i vagoane, apelati metodele si
afisati rezultatele pe ecran.
             */




            Locomotiva BulletTrain = new Locomotiva();
            Tren InterRegio = new Tren("Japanese Bullet Train", BulletTrain);

            InterRegio.AdaugaVagon(new VagonClasaIntai(2023, 1000, 99));
            InterRegio.AdaugaVagon(new VagonClasaIntai(2023, 1000, 99));
            InterRegio.AdaugaVagon(new VagonDePersoane(2019, 800, 200));
            InterRegio.AdaugaVagon(new VagonDePersoane(2019, 800, 200));
            InterRegio.AdaugaVagon(new VagonDeMarfa(2010, 5893, 100, TipMarfa.Cereale));

            InterRegio.PleacaDinGara();
            InterRegio.OpresteInGara();
        }
    }
}

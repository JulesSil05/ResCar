using System;
using System.Collections.Generic;
using System.Text;

namespace ResCar
{
    public class ApplicationData
    {
        public static List<Emprunt> listeEmprunts
        {
            get;
            set;
        }

        public static List<Employe> listeEmployes
        {
            get;
            set;
        }
        public static List<Vehicule> listeVehicules
        {
            get;
            set;
        }
        public static void loadApplicationData()
        {
            Emprunt unEmprunt = new Emprunt();
            Employe unEmploye = new Employe();
            Vehicule unVehicule = new Vehicule();
            listeEmprunts = unEmprunt.FindAll();
            listeEmployes = unEmploye.FindAll();
            listeVehicules = unVehicule.FindAll();
        }
    }
}

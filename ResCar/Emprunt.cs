// File:    Emprunt.cs
// Author:  silvejul
// Created: lundi 23 mai 2022 14:40:11
// Purpose: Definition of Class Emprunt

using ResCar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Emprunt : Crud<Emprunt>
{
    public string nomEmploye
    {
        get; set;
    }
    public string prenomEmploye
    {
        get; set;
    }
    public string libelleVehicule
    {
        get; set;
    }

    public int idEmprunt
    {
        get; set;
    }
    public int idEmploye
    {
        get; set;
    }
    public int idVehicule
    {
        get; set;
    }
    public string dateEmprunt
   {
        get; set;
   }
   
   public string libelleMission
   {
        get; set;
   }
   
   public Emprunt()
   {
 
   } 
   
   public void Create()
   {
        /*DataAccess access = new DataAccess();
        SqlDataReader reader;
        access.openConnection();
        reader = access.getData($"SELECT  (SELECT NOMEMPLOYE FROM EMPLOYE WHERE libellemaladie='{this.LibelleMaladie}') AS idmaladie, (SELECT NOMEMPLOYE FROM EMPLOYE WHERE libellemedicament='{this.LibelleMedicament}') AS idmedicament;");*/
   }
   
   public void Read()
   {
      throw new NotImplementedException();
   }
   
   public void Update()
   {
      throw new NotImplementedException();
   }
   
   public void Delete()
   {
        DataAccess access = new DataAccess();
        access.setData($"DELETE FROM EMPRUNTE WHERE IDEMPRUNT = {this.idEmprunt}");
   }
    public List<Emprunt> FindAll()
    {
        List<Emprunt> listeGroupes = new List<Emprunt>();
        DataAccess access = new DataAccess();
        SqlDataReader reader;
        try
        {
            if (access.openConnection())
            {
                reader = access.getData("select nomEmploye EMP, prenomEmploye EMP, libelleVehicule V, idEmprunt E, dateemprunt E, LIBELLEMISSION E from Emprunte E join Employe EMP on E.IDEMPLOYE = EMP.IDEMPLOYE join Vehicule V on E.IDVEHICULE = V.IDVEHICULE");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emprunt unEmprunt = new Emprunt();
                        unEmprunt.nomEmploye = reader.GetString(0);
                        unEmprunt.prenomEmploye = reader.GetString(1);
                        unEmprunt.libelleVehicule = reader.GetString(2);
                        unEmprunt.idEmprunt = reader.GetInt32(3);
                        unEmprunt.dateEmprunt = reader.GetString(4);
                        unEmprunt.libelleMission = reader.GetString(5);
                        listeGroupes.Add(unEmprunt);
                    }
                }
                else
                {
                    System.Windows.MessageBox.Show("No rows found.", "Important Message");
                }
                reader.Close();
                access.closeConnection();
            }
        }
        catch (Exception ex)
        {
            System.Windows.MessageBox.Show(ex.Message, "Important Message");
        }
        return listeGroupes;
    }

    public List<Emprunt> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}
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
      throw new NotImplementedException();
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
      throw new NotImplementedException();
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
                reader = access.getData("select * from Emprunte;");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Emprunt unEmprunt = new Emprunt();
                        unEmprunt.idEmploye = reader.GetInt32(0);
                        unEmprunt.idVehicule = reader.GetInt32(1);
                        unEmprunt.dateEmprunt = reader.GetString(2);
                        unEmprunt.libelleMission = reader.GetString(3);
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
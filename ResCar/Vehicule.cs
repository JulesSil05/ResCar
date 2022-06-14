// File:    Vehicule.cs
// Author:  silvejul
// Created: lundi 23 mai 2022 14:40:13
// Purpose: Definition of Class Vehicule

using ResCar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Vehicule : Crud<Vehicule>
{
   public int iDVehicule
   {
        get;set;
   }

    public int iDCategorie
    {
        get; set;
    }

    public string libelleVehicule
   {
        get;set;
   }
   
   public Vehicule()
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
   
   public Emprunt emprunt;
   public System.Collections.Generic.List<Categorie> categorie;
   
   /// <summary>
   /// Property for collection of Categorie
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Categorie> Categorie
   {
      get
      {
         if (categorie == null)
            categorie = new System.Collections.Generic.List<Categorie>();
         return categorie;
      }
      set
      {
         RemoveAllCategorie();
         if (value != null)
         {
            foreach (Categorie oCategorie in value)
               AddCategorie(oCategorie);
         }
      }
   }
   
   /// <summary>
   /// Add a new Categorie in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddCategorie(Categorie newCategorie)
   {
      if (newCategorie == null)
         return;
      if (this.categorie == null)
         this.categorie = new System.Collections.Generic.List<Categorie>();
      if (!this.categorie.Contains(newCategorie))
         this.categorie.Add(newCategorie);
   }
   
   /// <summary>
   /// Remove an existing Categorie from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveCategorie(Categorie oldCategorie)
   {
      if (oldCategorie == null)
         return;
      if (this.categorie != null)
         if (this.categorie.Contains(oldCategorie))
            this.categorie.Remove(oldCategorie);
   }
   
   /// <summary>
   /// Remove all instances of Categorie from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllCategorie()
   {
      if (categorie != null)
         categorie.Clear();
   }
    public List<Vehicule> FindAll()
    {
        List<Vehicule> listeVehicules = new List<Vehicule>();
        DataAccess access = new DataAccess();
        SqlDataReader reader;
        try
        {
            if (access.openConnection())
            {
                reader = access.getData("SELECT * FROM VEHICULE WHERE IDVEHICULE NOT IN (SELECT IDVEHICULE FROM EMPRUNTE)");
                
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Vehicule unVehicule = new Vehicule();
                        unVehicule.iDVehicule = reader.GetInt32(0);
                        unVehicule.iDCategorie = reader.GetInt32(1);
                        unVehicule.libelleVehicule = reader.GetString(2);
                        listeVehicules.Add(unVehicule);
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
        return listeVehicules;
    }

    public List<Vehicule> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}
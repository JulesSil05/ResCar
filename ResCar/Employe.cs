// File:    Employe.cs
// Author:  silvejul
// Created: lundi 23 mai 2022 14:40:07
// Purpose: Definition of Class Employe

using ResCar;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class Employe : Crud<Employe>
{
   public int iDEmploye
   {
        get; set;
    }
   
   public string nomEmploye
   {
        get; set;
    }
   
   public string prenomEmploye
   {
        get; set;
    }
   
   public string telEmploye
   {
        get; set;
    }
   
   public string mailEmploye
   {
        get; set;
   }
    public Employe()
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
   
   public System.Collections.Generic.List<Vehicule> vehicule;
   
   /// <summary>
   /// Property for collection of Vehicule
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Vehicule> Vehicule
   {
      get
      {
         if (vehicule == null)
            vehicule = new System.Collections.Generic.List<Vehicule>();
         return vehicule;
      }
      set
      {
         RemoveAllVehicule();
         if (value != null)
         {
            foreach (Vehicule oVehicule in value)
               AddVehicule(oVehicule);
         }
      }
   }
   
   /// <summary>
   /// Add a new Vehicule in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddVehicule(Vehicule newVehicule)
   {
      if (newVehicule == null)
         return;
      if (this.vehicule == null)
         this.vehicule = new System.Collections.Generic.List<Vehicule>();
      if (!this.vehicule.Contains(newVehicule))
         this.vehicule.Add(newVehicule);
   }
   
   /// <summary>
   /// Remove an existing Vehicule from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveVehicule(Vehicule oldVehicule)
   {
      if (oldVehicule == null)
         return;
      if (this.vehicule != null)
         if (this.vehicule.Contains(oldVehicule))
            this.vehicule.Remove(oldVehicule);
   }
   
   /// <summary>
   /// Remove all instances of Vehicule from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllVehicule()
   {
      if (vehicule != null)
         vehicule.Clear();
   }
   public System.Collections.Generic.List<Emprunt> emprunt;
   
   /// <summary>
   /// Property for collection of Emprunt
   /// </summary>
   /// <pdGenerated>Default opposite class collection property</pdGenerated>
   public System.Collections.Generic.List<Emprunt> Emprunt
   {
      get
      {
         if (emprunt == null)
            emprunt = new System.Collections.Generic.List<Emprunt>();
         return emprunt;
      }
      set
      {
         RemoveAllEmprunt();
         if (value != null)
         {
            foreach (Emprunt oEmprunt in value)
               AddEmprunt(oEmprunt);
         }
      }
   }
   
   /// <summary>
   /// Add a new Emprunt in the collection
   /// </summary>
   /// <pdGenerated>Default Add</pdGenerated>
   public void AddEmprunt(Emprunt newEmprunt)
   {
      if (newEmprunt == null)
         return;
      if (this.emprunt == null)
         this.emprunt = new System.Collections.Generic.List<Emprunt>();
      if (!this.emprunt.Contains(newEmprunt))
         this.emprunt.Add(newEmprunt);
   }
   
   /// <summary>
   /// Remove an existing Emprunt from the collection
   /// </summary>
   /// <pdGenerated>Default Remove</pdGenerated>
   public void RemoveEmprunt(Emprunt oldEmprunt)
   {
      if (oldEmprunt == null)
         return;
      if (this.emprunt != null)
         if (this.emprunt.Contains(oldEmprunt))
            this.emprunt.Remove(oldEmprunt);
   }
   
   /// <summary>
   /// Remove all instances of Emprunt from the collection
   /// </summary>
   /// <pdGenerated>Default removeAll</pdGenerated>
   public void RemoveAllEmprunt()
   {
      if (emprunt != null)
         emprunt.Clear();
   }

    public List<Employe> FindAll()
    {
        List<Employe> listeEmployes = new List<Employe>();
        DataAccess access = new DataAccess();
        SqlDataReader reader;
        try
        {
            if (access.openConnection())
            {
                reader = access.getData("select * from Employe;");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Employe unEmploye = new Employe();
                        unEmploye.iDEmploye = reader.GetInt32(0);
                        unEmploye.nomEmploye = reader.GetString(1);
                        unEmploye.prenomEmploye = reader.GetString(2);
                        unEmploye.telEmploye = reader.GetString(3);
                        unEmploye.mailEmploye = reader.GetString(4);
                        listeEmployes.Add(unEmploye);
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
        return listeEmployes;
    }

    public List<Employe> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}
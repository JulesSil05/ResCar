// File:    Categorie.cs
// Author:  silvejul
// Created: lundi 23 mai 2022 14:40:12
// Purpose: Definition of Class Categorie

using ResCar;
using System;
using System.Collections.Generic;

public class Categorie : Crud<Categorie>
{
   public int iDCategorie
   {
      get
      {
         throw new NotImplementedException();
      }
      set
      {
         throw new NotImplementedException();
      }
   }
    public string nomCategorie
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }

    public Categorie(int iDCategorie, string nomCategorie)
   {
      throw new NotImplementedException();
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

    public List<Categorie> FindAll()
    {
        throw new NotImplementedException();
    }

    public List<Categorie> FindBySelection(string criteres)
    {
        throw new NotImplementedException();
    }
}
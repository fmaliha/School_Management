using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace InovexiaEBS
{
    public class BLACProduct
    {
        public static long InsertACProduct(BOACProduct boItem)
        {

            DAACProduct objDA = new DAACProduct();
            return Convert.ToInt64(objDA.InsertACProduct(boItem));
        }
    }
}
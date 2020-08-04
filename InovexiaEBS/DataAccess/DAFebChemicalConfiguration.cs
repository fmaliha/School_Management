using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;

namespace InovexiaEBS
{
    public class DAFebChemicalConfiguration
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();
        public long insertChemicalConfiguration(BOFebChemicalConfiguration boaddemp)
        {
            var ht = new Hashtable();

            ht.Add("Sample", boaddemp.Sample);
            ht.Add("SWeight", boaddemp.SWeight);
            ht.Add("EWeight", boaddemp.EWeight);
            ht.Add("ChemicalId", boaddemp.ChemicalId);
            ht.Add("ChemicalWeight", boaddemp.ChemicalWeight);
            ht.Add("Transfered", boaddemp.Transfered1);
            ht.Add("AddedBy", boaddemp.AddedBy1);
            ht.Add("DateAdded", boaddemp.DateAdded1);
            ht.Add("UpdatedBy", boaddemp.UpdatedBy1);
            ht.Add("DateUpdated", boaddemp.DateUpdated1);
            ht.Add("SerialNo", boaddemp.SerialNo);
            return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertChemicalConfiguration"));
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;

namespace InovexiaEBS
{
    public class DAFebChemicalConsumption
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();
        public long insertChemicalConsumption(BOFebChemicalConsumption boclient)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("SampleID", boclient.SampleNo);
                ht.Add("ChemicalID", boclient.ChemicalID);
                ht.Add("ChemicalWeight", boclient.ChemicalWeight);
                ht.Add("Transfered", boclient.Transfered1);
                ht.Add("AddedBy", boclient.AddedBy1);
                ht.Add("DateAdded", boclient.DateAdded1);
                ht.Add("UpdatedBy", boclient.UpdatedBy1);
                ht.Add("DateUpdated", boclient.DateUpdated1);
                ht.Add("SerialNo", boclient.SerialNo);
                ht.Add("ProductionStageFlag", boclient.ProductionStageFlag);
                return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertChemicalConsumption"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PBSConnLib;

namespace InovexiaEBS
{
    public class DAYarnConsumption
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();
        public long insertYarnConsumption(BOYarnConsumption boclient)
        {
            try
            {
                var ht = new Hashtable();
                ht.Add("SampleID", boclient.SampleNo);
                ht.Add("YarnID", boclient.YarnID);
                ht.Add("YarnCount", boclient.YarnCount);
                ht.Add("CountSpecification", boclient.CountSpecification);
                ht.Add("LotNo", boclient.LotNo);
                ht.Add("Beam", boclient.Beam);
                ht.Add("KGPerYd", boclient.KGPerYd);
                ht.Add("TotalEnds", boclient.TotalEnds);
                ht.Add("Transfered", boclient.Transfered1);
                ht.Add("AddedBy", boclient.AddedBy1);
                ht.Add("DateAdded", boclient.DateAdded1);
                ht.Add("UpdatedBy", boclient.UpdatedBy1);
                ht.Add("DateUpdated", boclient.DateUpdated1);
                ht.Add("SerialNo", boclient.SerialNo);
                ht.Add("ProductionStageFlag", boclient.ProductionStageFlag);
                return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertYarnConsumption"));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
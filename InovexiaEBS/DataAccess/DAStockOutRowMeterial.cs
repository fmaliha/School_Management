using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using PBSConnLib;

namespace InovexiaEBS
{
    public class DAStockOutRowMeterial
    {
        PBSDBUtility iDBUtility = new PBSDBUtility();

        public DataTable GetRate(int doValue)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("SampleID", doValue);
                return iDBUtility.GetDataByProc(ht, "dbo.sp_YarnRate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetRateFromChemical(int doValue)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("SampleID", doValue);
                return iDBUtility.GetDataByProc(ht, "dbo.sp_ChemicalRate");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
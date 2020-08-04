using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class AccountPayableEntryDLL
    {
        PBSDBUtility pbs = new PBSDBUtility();
        internal long SaveAccountPayableEntryData(VmStudentRegistration objvm)
        {
            try
            {
                string V = string.Empty;
                Hashtable ht = new Hashtable();

                ht.Add("MonthP", objvm.EMonth);
                ht.Add("YearP", objvm.EYear);
                ht.Add("PaymentHeadP", objvm.EPayHead);
                ht.Add("AmountP", objvm.EAmount);
                ht.Add("NarrationP", objvm.ENarration);
                V = pbs.GetDataByProc(ht, "SM_SaveAccountPayableEntry").Rows[0]["TID"].ToString();

                return long.Parse(V);
            }
            catch (Exception ex)
            {
                Alert.ShowMessage("Amount can Only be  Numeric");
                //throw new Exception(ex.Message.ToString());
                return 0;
            }
        }


    }
}
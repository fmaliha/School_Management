using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class AccountReceiveableEntryDLL
    {
        PBSDBUtility pbs = new PBSDBUtility();
        internal long SaveAccountReceiveableEntryData(VmStudentRegistration objvm)
        {
            try
            {
                string V = string.Empty;
                Hashtable ht = new Hashtable();

                ht.Add("MonthE", objvm.EMonth);
                ht.Add("YearE", objvm.EYear);
                ht.Add("PaymentHead", objvm.EPayHead);
                ht.Add("Amount", objvm.EAmount);
                ht.Add("Narration", objvm.ENarration);
                V = pbs.GetDataByProc(ht, "SM_SaveAccountReceiveableEntry").Rows[0]["TID"].ToString();

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
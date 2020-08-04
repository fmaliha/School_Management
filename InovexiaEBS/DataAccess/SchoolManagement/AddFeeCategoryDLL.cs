using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class AddFeeCategoryDLL
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();

        internal DataTable CheckFeeCategory(Hashtable ht)
        {
            try
            {
                DataTable dbt = pbsUtility.GetDataByProc(ht, "SM_CheckFeeCategory");
                    return dbt;
               
            }
            catch (Exception ex)
            {

                 throw new Exception(ex.Message.ToString());
            }

        }

        internal long SaveAddFeeCategory(VmStudentRegistration model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("HeadName", model.FeeCategory);
                ht.Add("FeesFrequency", model.FeeFrequency);
                


                result = pbsUtility.InsertData(ht, "SM_SaveAddFeeCategory");
                return result;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
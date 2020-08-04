using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PBSConnLib;

using System.Collections;
using System.Web.UI;

namespace InovexiaEBS
{
    public class DAPartexHRM
    {
        PBSDBUtility idbutility = new PBSDBUtility();

        public long InsertPartex_HRM_Dept(BOPartexHRM boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("DeptID", boItem.DeptID1);
                ht.Add("DeptName", boItem.DeptName1);
                ht.Add("Description", boItem.Description1);
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPartex_HRM_Dept"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long InsertPartex_HRM_Desig(BOPartexHRM boItem)
         {
             try
             {
                 Hashtable ht = new Hashtable();
                 ht.Add("DesignationID", boItem.DesignationID1);
                 ht.Add("DesignationName", boItem.DesignationName1);
                 return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPartex_HRM_Desig"));
             }
             catch (Exception ex)
             {
                 throw ex;
             }
    
        }

        public long InsertPartex_HRM_EmployeeMaster(BOPartexHRM boItem)
        {
            try
            
            {
            Hashtable ht = new Hashtable();
            ht.Add("EmployeeID",boItem.EmployeeID1);
            
	        ht.Add("EmployeeName",boItem.EmployeeName1);
	        ht.Add("CompanyID",boItem.CompanyID1);
            ht.Add("JoiningDate", boItem.JoiningDate1);
            ht.Add("HihgestEduQualification", boItem.HihgestEduQualification1);
	        ht.Add("DeptID",boItem.DeptID1);
	        ht.Add("DesignationID",boItem.DesignationID1);
	       
            ht.Add("IsActive", boItem.IsActive1);
            ht.Add("CreatedBy", boItem.CreatedBy1);
            ht.Add("CreatdeDate", boItem.CreatdeDate1);
            ht.Add("UpdatedBy", boItem.UpdatedBy1);
            ht.Add("UpdatedDate", boItem.UpdatedDate1);
            return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPartex_HRM_EmployeeMaster"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
       
        }
        public long InsertPartex_HRM_JD(BOPartexHRM boItem)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EmployeeID", boItem.EmployeeID1);

                ht.Add("WorkToDo", boItem.WorkToDo1);
                ht.Add("ReportTowhome", boItem.ReportTowhome1);
                ht.Add("SuccessInfo", boItem.SuccessInfo1);
                ht.Add("FailureInfo", boItem.FailureInfo1);
                ht.Add("ProblemArea", boItem.ProblemArea1);
                ht.Add("SuggestionInfo", boItem.SuggestionInfo1);
                ht.Add("HelpInfo", boItem.HelpInfo1);
                ht.Add("Remarks", boItem.Remarks1);
                ht.Add("JDYear", boItem.JDYear1);
                ht.Add("JDStatus", boItem.JDStatus1);

                ht.Add("IsActive", boItem.IsActive1);
                ht.Add("CreatedBy", boItem.CreatedBy1);
                ht.Add("CreatdeDate", boItem.CreatdeDate1);
                ht.Add("UpdatedBy", boItem.UpdatedBy1);
                ht.Add("UpdatedDate", boItem.UpdatedDate1);
                ht.Add("TransactionID", boItem.TransactionID1);
                return Convert.ToInt64(idbutility.InsertData(ht, "spInsertPartex_HRM_JD"));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
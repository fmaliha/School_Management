using InovexiaEBS.BusinessEntity.Enterprise;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.Enterprise
{
    public class DAEnterpriseRequiredHr
    {


        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseRequiredHr(BOEnterpriseRequiredHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseRequiredHrID", model.EnterpriseRequiredHrID);
                ht.Add("EnterpriseID", model.EnterpriseID);

                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationLevel", model.HighestEducationLevel);
                ht.Add("HighestEducationLevelID", model.HighestEducationLevelID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("TotalRequiredNo", model.TotalRequiredNo);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);              
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseRequiredHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseRequiredHr(BOEnterpriseRequiredHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseRequiredHrID", model.EnterpriseRequiredHrID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("Designation", model.Designation);
                ht.Add("HighestEducationLevel", model.HighestEducationLevel);
                ht.Add("HighestEducationLevelID", model.HighestEducationLevelID);
                ht.Add("SpecializationID", model.SpecializationID);
                ht.Add("HrTypeID", model.HrTypeID);
                ht.Add("JobTypeID", model.JobTypeID);
                ht.Add("TotalRequiredNo", model.TotalRequiredNo);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);       


                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseRequiredHr"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseRequiredHr(int CategoryId)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("CategoryId", CategoryId);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetEnterpriseRequiredHr");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseRequiredHrById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseRequiredHrById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseRequiredHr(BOEnterpriseRequiredHr model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseRequiredHrID", model.EnterpriseRequiredHrID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC); 
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "[sp_DeleteEnterpriseRequiredHr]"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
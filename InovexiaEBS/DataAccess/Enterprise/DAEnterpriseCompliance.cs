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
    public class DAEnterpriseCompliance
    {


        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertEnterpriseCompliance(BOEnterpriseCompliance model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseComplianceID", model.EnterpriseComplianceID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ComplianceTypeID", model.ComplianceTypeID);
                
                ht.Add("EffectFromYearID", model.EffectFromYearID);
                ht.Add("IsActive", model.IsActive);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedAt", model.CreatedAt);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("UpdatedAt", model.UpdatedAt);
                ht.Add("UpdatedBy", model.UpdatedBy);
                ht.Add("UpdatedPC", model.UpdatedPC);
                ht.Add("IsDeleted", model.IsDeleted);
                ht.Add("DeletedBy", model.DeletedBy);
                ht.Add("DeletedPC", model.DeletedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertEnterpriseCompliance"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateEnterpriseCompliance(BOEnterpriseCompliance model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseComplianceID", model.EnterpriseComplianceID);
                ht.Add("EnterpriseID", model.EnterpriseID);
                ht.Add("ComplianceTypeID", model.ComplianceTypeID);
                ht.Add("EffectFromYearID", model.EffectFromYearID);
                ht.Add("IsActive", model.IsActive);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedAt", model.CreatedAt);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("UpdatedAt", model.UpdatedAt);
                ht.Add("UpdatedBy", model.UpdatedBy);
                ht.Add("UpdatedPC", model.UpdatedPC);
                ht.Add("IsDeleted", model.IsDeleted);
                ht.Add("DeletedBy", model.DeletedBy);
                ht.Add("DeletedPC", model.DeletedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateEnterpriseCompliance"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseCompliance(Hashtable ht)
        {
            try
            { 
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetEnterpriseCompliance");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseComplianceById(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseComplianceById");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteEnterpriseCompliance(BOEnterpriseCompliance model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("EnterpriseComplianceID", model.EnterpriseComplianceID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                result = Convert.ToInt64(pbsUtility.InsertData(ht, "[sp_DeleteEnterpriseCompliance]"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
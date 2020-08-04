using InovexiaEBS.BusinessEntity.TextileEducation;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.TextileEducation
{
    public class DADocumentManage
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        public long InsertDocumentManage(BODocumentMange model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("FileName", model.FileName);
                ht.Add("OrginalFileName", model.OrginalFileName);                
                ht.Add("InstitutionId", model.InstitutionId);
                ht.Add("TypeId", model.TypeId);              
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
               

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertDocumentMange"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        public long UpdateDocumentManage(BODocumentMange model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("DocManageId", model.DocManageId);
                ht.Add("FileName", model.FileName);
                ht.Add("InstitutionId", model.InstitutionId);
                ht.Add("TypeId", model.TypeId);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateDocumentMange"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public long DeleteDocumentManage(BODocumentMange model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("DocManageId", model.DocManageId);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteDocumentMange"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GETDocumentManages(int Type)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("TypeId", Type);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_GetDocumentManageList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        //public DataTable GETInstitutionProgramWiseStudentById(Hashtable ht)
        //{
        //    try
        //    {
        //        DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetInstitutionProgramWiseStudentById");
        //        return dataTable;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        internal DataTable LoadDocumentsByInstitutionId(int InstitutionID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("InstitutionID", InstitutionID);
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetDocumentManageListByInstitutionID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETEnterpriseDocumentManages(int DocumentType, int EnPriseCategoryID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("TypeId", DocumentType);
                ht.Add("EnPriseCategoryID", EnPriseCategoryID);
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_GetEnterpriseDocumentManageList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
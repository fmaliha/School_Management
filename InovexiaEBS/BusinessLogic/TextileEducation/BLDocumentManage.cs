using InovexiaEBS.BusinessEntity.TextileEducation;
using InovexiaEBS.DataAccess.TextileEducation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessLogic.TextileEducation
{
    public class BLDocumentManage
    {
        internal static long InsertDocumentManage(BODocumentMange model)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return Convert.ToInt64(accessLayer.InsertDocumentManage(model));
        }

        internal static long UpdateDocumentManage(BODocumentMange model)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return Convert.ToInt64(accessLayer.UpdateDocumentManage(model));
        }

        internal static long DeleteDocumentManage(BODocumentMange model)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return Convert.ToInt64(accessLayer.DeleteDocumentManage(model));
        }

        internal static DataTable GETDocumentManages(int Type)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return accessLayer.GETDocumentManages(Type);
        }




        internal static DataTable LoadDocumentsByInstitutionId(int InstitutionID)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return accessLayer.LoadDocumentsByInstitutionId(InstitutionID);
        }

        internal static DataTable GETEnterpriseDocumentManages(int DocumentType, int EnPriseCategoryID)
        {
            DADocumentManage accessLayer = new DADocumentManage();
            return accessLayer.GETEnterpriseDocumentManages(DocumentType, EnPriseCategoryID);
        }
    }
}
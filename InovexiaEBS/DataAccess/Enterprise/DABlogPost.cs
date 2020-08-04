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
    public class DABlogPost
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();
        internal long InsertBlogPost(BOBlogPost model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("PostTypeID", model.PostTypeID);
                ht.Add("PostTitle", model.PostTitle);
                ht.Add("Details", model.Details);
                ht.Add("Remarks", model.Remarks);                
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);
                ht.Add("EnterpriseCategoryID", model.EnterpriseCategoryID);
                

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_InsertBlogPost"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long UpdateBlogPost(BOBlogPost model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();

                ht.Add("BlogPostID", model.BlogPostID);
                ht.Add("PostTypeID", model.PostTypeID);
                ht.Add("PostTitle", model.PostTitle);
                ht.Add("Details", model.Details);
                ht.Add("Remarks", model.Remarks);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_UpdateBlogPost"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal long DeleteBlogPost(BOBlogPost model)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();
                ht.Add("BlogPostID", model.BlogPostID);
                ht.Add("CreatedBy", model.CreatedBy);
                ht.Add("CreatedPC", model.CreatedPC);

                result = Convert.ToInt64(pbsUtility.InsertData(ht, "sp_DeleteBlogPost"));
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETBlogPostList(int EnterprisePriseCategoryID)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("EnterprisePriseCategoryID", EnterprisePriseCategoryID);
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"Sp_GetBlogPostList");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GETBlogPostByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "Sp_GetBlogPostByID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
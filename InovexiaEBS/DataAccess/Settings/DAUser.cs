using InovexiaEBS.BusinessEntity.PBML.Settings;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.Settings
{
    public class DAUser
    {

        PBSDBUtility idbutility = new PBSDBUtility();
        public long InsertUser(User _objUser)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("name", _objUser.UserName);
                ht.Add("login_id", _objUser.LoginID);
                ht.Add("password", _objUser.Password);
                ht.Add("email", _objUser.Email);
                ht.Add("ContactNumber", _objUser.ContactNumber);
                ht.Add("CreateBy", _objUser.CreatedBy);
                DataTable  dt = idbutility.GetDataByProc(ht, "spInsertUser");
                if (dt.Rows.Count > 0)
                {
                    string Value = dt.Rows[0]["pin_number"].ToString();
                    // return Convert.ToInt64(idbutility.ExecuteCommand(ht, "spInsertUser"));
                    return Convert.ToInt64(Value);
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public long UpdateUser(User _objUser)
        {
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("pin_number", _objUser.pin_number);
                ht.Add("name", _objUser.UserName);
                ht.Add("login_id", _objUser.LoginID);
                ht.Add("password", _objUser.Password);
                ht.Add("email", _objUser.Email);
                ht.Add("ContactNumber", _objUser.ContactNumber);
                ht.Add("CreateBy", _objUser.CreatedBy);
                DataTable dt = idbutility.GetDataByProc(ht, "spUpdateUser");
                if (dt.Rows.Count > 0)
                {
                    string Value = dt.Rows[0]["pin_number"].ToString();
                    return Convert.ToInt64(Value);
                }
                else
                {
                    return 0;
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //public long InsertUserStackholder(vmUser_Stackholder _objUser)
        //{
        //    try
        //    {
        //        Hashtable ht = new Hashtable();
        //        ht.Add("MappingID", _objUser.MappingID);
        //        ht.Add("pin_number", _objUser.pin_number); 
        //        ht.Add("StakeholderTypeID", _objUser.StakeholderTypeID);
        //        ht.Add("StakeholderName", _objUser.StakeholderName);
        //        ht.Add("CreatedBy", _objUser.CreatedBy);
        //        return Convert.ToInt64(idbutility.InsertData(ht, "spInsertUserStackholder"));


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}



        
    }
}
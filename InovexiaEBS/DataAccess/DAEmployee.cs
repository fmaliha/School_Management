using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PBSConnLib;

// Created By: Nafiz

    public class DAEmployee
    {
        PBSDBUtility iPBSDBUtility = new PBSDBUtility();

        public DataTable GetAllEmployeeList()
        {
         DataTable table = iPBSDBUtility.GetDataBySQLString("SELECT * from dbo.user_t");
         return table; 
        }

        public DataTable GetAllEmployeeAsaList()
        {
        DataTable DTab = iPBSDBUtility.GetDataBySQLString("SELECT * from dbo.user_t ");
        return DTab;
        }

        public DataTable GetAllEmployees()
        {
            DataTable DTab = iPBSDBUtility.GetDataBySQLString("SELECT pin_number,name,login_id,email from dbo.user_t ");
            return DTab;
        }

        public DataTable GetEmployeeDetails(string code)
        {
            DataTable DTab = iPBSDBUtility.GetDataBySQLString("SELECT code, pin_number, name,login_id, email, is_active from dbo.user_t WHERE pin_number='" + code + "' or name like '%" + code + "%' ");
            return DTab;
        }

        public long InsertEmployee(BOEmployee objBO)
        {
            
            
            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("pin_number", objBO.Pin);
                ht.Add("name", objBO.Name);
                ht.Add("login_id", objBO.Login_Id);
                ht.Add("password", objBO.Password);
                ht.Add("email", objBO.Email);
                ht.Add("creator", objBO.Creator);
                ht.Add("modifier", objBO.Modifier);
                ht.Add("is_active", objBO.IsActive);

                return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "dbo.insert_update_user_t"));
            }
            catch (Exception ex)
            {
                throw ex;
                              
                
            }
        }
        public long ChangePassword(BOEmployee objBO)
        {
           
           

            try
            {
                string sql = "SET NOCOUNT ON SELECT pin_number FROM dbo.user_t WHERE pin_number='" + objBO.Pin + "' AND Password='" + objBO.OldPassword + "'";
                DataTable dt = iPBSDBUtility.GetDataBySQLString(sql);
               
                if (dt.Rows.Count > 0)
                {
                    Hashtable ht = new Hashtable();
                    ht.Add("pin_number", objBO.Pin);
                    ht.Add("Oldpassword", objBO.OldPassword);
                    ht.Add("Newpassword", objBO.Password);

                    return Convert.ToInt64(iPBSDBUtility.ExecuteCommand(ht, "dbo.Update_aa"));
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       
        public long InsertEmployeeDetails(BOEmployee objBO)
        {
            try
            {  
                Hashtable ht = new Hashtable();
                ht.Add("code", objBO.Code);
                ht.Add("name", objBO.Name);
                ht.Add("login_name", objBO.Login_Id);
                ht.Add("address", objBO.Address);
                return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "dbo.insert_bb"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


   }
    
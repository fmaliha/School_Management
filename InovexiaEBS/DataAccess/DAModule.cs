using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using PBSConnLib;

public class DAModule
{
	public DAModule()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    PBSDBUtility iPBSDBUtility = new PBSDBUtility();

    public long InsertModule(BOCommon objBO)
    {        
        try
        {
            Hashtable ht = new Hashtable();
            //ht.Add("code", objBO.Code);insert_update_sa_module_t
            ht.Add("name", objBO.Name);
            return Convert.ToInt64(iPBSDBUtility.InsertData(ht, "dbo.insert_update_sa_module_t"));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}

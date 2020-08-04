using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for BLEmployee
/// </summary>
public class BLEmployee
{
    
	public BLEmployee()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static long InsertEmployee(BOEmployee objBO)
    {
        DAEmployee objDA = new DAEmployee();
        return Convert.ToInt64(objDA.InsertEmployee(objBO));
    }
    public static long ChangePassword(BOEmployee objBO)
    {
        DAEmployee objDA = new DAEmployee();
        return Convert.ToInt64(objDA.ChangePassword(objBO));
    }

    public static long InsertEmployeeDetails(BOEmployee objBO)
    {
        DAEmployee objDA = new DAEmployee();
        return Convert.ToInt64(objDA.InsertEmployeeDetails(objBO));
    }

    public static DataTable SelectEmployeeDetails(string code)
    {
        DAEmployee objDA = new DAEmployee();
        DataTable Dtab = objDA.GetEmployeeDetails(code);
        return Dtab;      
    }

    public static EmployeeList GetEmployeeAsaList()
    {
        EmployeeList objList = new EmployeeList();
            
        DAEmployee objDA = new DAEmployee();        
        DataTable table = objDA.GetAllEmployeeList();
        foreach (DataRow dr in table.Rows)
        {
            BOEmployee objBO = new BOEmployee();
            objBO.Code = dr["code"].ToString();
            objBO.Pin = dr["pin_number"].ToString();
            objBO.Name = dr["name"].ToString();
            objBO.Email = dr["email"].ToString();
          //  objBO.Password = dr["password"].ToString();
            objList.AddToList(objBO);
        }
        return objList;
    }

    public static DataTable GetAllEmployees()
    {
        DAEmployee objDA = new DAEmployee();
        DataTable Dtab = objDA.GetAllEmployees();
        return Dtab;
    }

    public static DataTable GetEmployeesByOption(string option)
    {
        DAEmployee objDA = new DAEmployee();
        DataTable Dtab = objDA.GetEmployeeDetails(option);
        return Dtab;
    }

}

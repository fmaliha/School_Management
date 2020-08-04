using System;
using System.Data;
using System.Collections; 
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for BOBase
/// </summary>
public class BOCommon
{
    public BOCommon()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    private string code = null;

    public string Code
    {
        get { return code; }
        set { code = value; }
    }
    

    private string idenity_id = null;

    public string Idenity_id
    {
        get { return idenity_id; }
        set { idenity_id = value; }
    }

    private string value = null;

    public string Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    private string name = null;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    private string description = null;

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private string address = null;

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    private string phone = null;

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    private string email = null;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private string contactperson = null;

    public string Contactperson
    {
        get { return contactperson; }
        set { contactperson = value; }
    }

    private string contactphone = null;

    public string Contactphone
    {
        get { return contactphone; }
        set { contactphone = value; }
    }

    private Boolean isactive=false;

    public Boolean IsActive
    {
        get { return isactive; }
        set { isactive = value; }
    }

    private string creator = null;

    public string Creator
    {
        get { return creator; }
        set { creator = value; }
    }
    private DateTime creation_date;

    public DateTime Creation_date
    {
        get { return creation_date; }
        set { creation_date = value; }
    }
    
    private string modifier = null;

    public string Modifier
    {
        get { return modifier; }
        set { modifier = value; }
    }
    private string themes = null;

    public string Themes
    {
        get { return themes; }
        set { themes = value; }
    }

    

}




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

public class BOUserAccess : BOCommon
{
    
    public BOUserAccess()
    {
        //
        // TODO: Add constructor logic here
        //Modifier By Rezaul
    }

    private string code = null;

    public string Code
    {
        get { return code; }
        set { code = value; }
    }
    private string name = null;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private int pin_number;

    public int Pin_number
    {
        get { return pin_number; }
        set { pin_number = value; }
    }
    private int menu_code;

    public int Menu_code
    {
        get { return menu_code; }
        set { menu_code = value; }
    }

    private string menu_name = null;

    public string Menu_name
    {
        get { return menu_name; }
        set { menu_name = value; }
    }

    private int module_code;

    public int Module_code
    {
        get { return module_code; }
        set { module_code = value; }
    }


    private string Module_name = null;

    public string Module_name1
    {
        get { return Module_name; }
        set { Module_name = value; }
    }

   

    private string screen_name = null;

    public string Screen_name
    {
        get { return screen_name; }
        set { screen_name = value; }
    }
    private int screen_code;

    public int Screen_code
    {
        get { return screen_code; }
        set { screen_code = value; }
    }

    private string login_id ;

    public string Login_id
    {
        get { return login_id; }
        set { login_id = value; }
    }

    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }



}

public class userlist : CollectionBase
{
    public userlist()
    {
        InnerList.Clear();
    }
    public void AddToList(BLUserAccess  objBO)
    {
        InnerList.Add(objBO);

    }



}
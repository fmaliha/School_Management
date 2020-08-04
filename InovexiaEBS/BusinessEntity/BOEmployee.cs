using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

    public class BOEmployee:BOCommon
    {
       BLEmployee iBLEmployee = new BLEmployee();
        public BOEmployee()
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

        private string pin = null;
        public string Pin
        {
            get { return pin; }
            set { pin = value; }
        }

        private string name = null;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string login_id = null;
        public string Login_Id
        {
            get { return login_id; }
            set { login_id = value; }
        }

        private Boolean isactive = false;

        public Boolean IsActive
        {
            get { return isactive; }
            set { isactive = value; }
        }

        private string creator = "sa";

        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        private string modifier = "sa";

        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }

        private string address = null;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string email = null;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password = null;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string oldpassword = null;
        public string OldPassword
        {
            get { return oldpassword; }
            set { oldpassword = value; }
        }
               
       
        
    }

    public class EmployeeList:CollectionBase 
    {
        public EmployeeList()
        {
            InnerList.Clear();  
        }
        public void AddToList(BOEmployee objBO)
        {
            InnerList.Add(objBO);
            
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class BLPBML_SDM_MRMaster
    {
        public static long InsertPBML_SDM_MRMaster(BOPBML_SDM_MRMaster boItem)
        {

            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();

            return Convert.ToInt64(objDA.InsertPBML_SDM_MRMaster(boItem));
        }

        public static long InsertPBML_SDM_MRMaster(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.InsertPBML_SDM_MRMaster(boItem, branchName, checkStatus));
        }

        public static long Insert_Supplier_Payment_BL(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.Insert_Supplier_Payment_DA (boItem, branchName, checkStatus));
        }


        public static long Insert_Client_Payment_BL(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.Insert_Client_Payment_DA(boItem, branchName, checkStatus));
        }




        public static long InsertPBML_SDM_MRMasterReverse(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.InsertPBML_SDM_MRMasterReverse(boItem, branchName, checkStatus));
        }




        public static long InsertPBML_SDM_ChequeInfo(BOPBML_SDM_MRMaster boItemChk)
        {

            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.InsertPBML_SDM_ChequeInfo(boItemChk));
        }

        public static long UpdatePBML_SDM_ChequeInfo(BOPBML_SDM_MRMaster boItemChkUpdate)
        {

            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.UpdatePBML_SDM_ChequeInfo(boItemChkUpdate));
        }


        public static long InsertPBML_SDM_MRMasterBoards(BOPBML_SDM_MRMaster boItem, string branchName, string checkStatus)
        {
            DAPBML_SDM_MRMaster objDA = new DAPBML_SDM_MRMaster();
            return Convert.ToInt64(objDA.InsertPBML_SDM_MRMasterBoards(boItem, branchName, checkStatus));
        }
    }

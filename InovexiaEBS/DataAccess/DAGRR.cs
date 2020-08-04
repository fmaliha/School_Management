using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using PBSConnLib;
using System.Collections;


    public class DAGRR
    {



        PBSDBUtility iDBUtility = new PBSDBUtility();

     public DAGRR()
    {

    }

    public long insertGRR(BOGRR  boaddemp)
    {
        Hashtable ht = new Hashtable();

        ht.Add("GRRNo", boaddemp.GRRNo1 );
        ht.Add("GRRDate", boaddemp.GRRDate1 );
        ht.Add("company_id ", boaddemp.Company_id);
        ht.Add("ChallanNo", boaddemp.ChallanNo1 );
        ht.Add("ChallanDate ", boaddemp.ChallanDate1 );
        ht.Add("Remarks", boaddemp.Remarks1 );
        ht.Add("EntryID", boaddemp.EntryID1 );
        ht.Add("EntryDate", boaddemp.EntryDate1 );
        ht.Add("QCStatus", boaddemp.QCStatus1 );
       ht.Add("pono", boaddemp.Pono );



        return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertGRRMasterDCL"));

    }

    public long insertGRRDetail(BOGRR  boaddemp)
    {
        Hashtable ht = new Hashtable();

        ht.Add("GRRNo", boaddemp.GRRNo1 );
        ht.Add("pono", boaddemp.Pono );
        ht.Add("ProductID", boaddemp.ProductID1 );
        ht.Add("OrdQty", boaddemp.OrdQty1 );
        ht.Add("RcvdQty", boaddemp.RcvdQty1 );
        ht.Add("IsQC", boaddemp.IsQC1 );
        ht.Add("QCBy", boaddemp.QCBy1 );
        ht.Add("QCDescription", boaddemp.QCDescription1 );



        return Convert.ToInt32(iDBUtility.InsertData(ht, "spInsertGRRDetailDCL"));

    }

    }

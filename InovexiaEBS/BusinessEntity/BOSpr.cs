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


/// <summary>
/// Summary description for BOSpr
/// </summary>
public class BOSpr
{
    public BOSpr()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private Boolean IsPurchase;

    public Boolean IsPurchase1
    {
        get { return IsPurchase; }
        set { IsPurchase = value; }
    }

    private string id = null;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }



    private string spr_no = null;

    public string Spr_no
    {
        get { return spr_no; }
        set { spr_no = value; }
    }
    private string company_id = null;

    public string Company_id
    {
        get { return company_id; }
        set { company_id = value; }
    }
    private string dept_id = null;

    public string Dept_id
    {
        get { return dept_id; }
        set { dept_id = value; }
    }
    private string login_id = null;

    public string Login_id
    {
        get { return login_id; }
        set { login_id = value; }
    }
    private DateTime spr_date;

    public DateTime Spr_date
    {
        get { return spr_date; }
        set { spr_date = value; }
    }
    private string acc_ap = null;

    public string Acc_ap
    {
        get { return acc_ap; }
        set { acc_ap = value; }
    }
    private string ed_app = null;

    public string Ed_app
    {
        get { return ed_app; }
        set { ed_app = value; }
    }

    private DateTime ending_date;

    public DateTime Ending_date
    {
        get { return ending_date; }
        set { ending_date = value; }
    }



    private int status;

    public int Status
    {
        get { return status; }
        set { status = value; }
    }


    /////////////////////sprdetails-------------------

    private int product_id;

    public int Product_id
    {
        get { return product_id; }
        set { product_id = value; }
    }

    private string MRFNo;

    public string MRFNo1
    {
        get { return MRFNo; }
        set { MRFNo = value; }
    }

    private string store_code = null;

    public string Store_code
    {
        get { return store_code; }
        set { store_code = value; }
    }

    private decimal quantity_required;

    public decimal Quantity_required
    {
        get { return quantity_required; }
        set { quantity_required = value; }
    }

    private decimal est_unit_price;

    public decimal Est_unit_price
    {
        get { return est_unit_price; }
        set { est_unit_price = value; }
    }



    private decimal last_punit_price;

    public decimal Last_punit_price
    {
        get { return last_punit_price; }
        set { last_punit_price = value; }
    }
    private string mrr_no = null;

    public string Mrr_no
    {
        get { return mrr_no; }
        set { mrr_no = value; }
    }

    private DateTime mrr_date;

    public DateTime Mrr_date
    {
        get { return mrr_date; }
        set { mrr_date = value; }
    }

    private decimal mrr_qty;

    public decimal Mrr_qty
    {
        get { return mrr_qty; }
        set { mrr_qty = value; }
    }

    private decimal stock_qty;

    public decimal Stock_qty
    {
        get { return stock_qty; }
        set { stock_qty = value; }
    }

    private string remarks = null;

    public string Remarks
    {
        get { return remarks; }
        set { remarks = value; }
    }

}

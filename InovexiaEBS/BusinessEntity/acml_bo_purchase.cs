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



public class acml_bo_purchase
{
    public acml_bo_purchase()
    {

    }

    private Boolean IsGRR;

    public Boolean IsGRR1
    {
        get { return IsGRR; }
        set { IsGRR = value; }
    }



    private string pono;

    public string Pono
    {
        get { return pono; }
        set { pono = value; }
    }
    private DateTime podate;

    public DateTime Podate
    {
        get { return podate; }
        set { podate = value; }
    }
    private string spr_no;

    public string Spr_no
    {
        get { return spr_no; }
        set { spr_no = value; }
    }
    private string vendorid;

    public string Vendorid
    {
        get { return vendorid; }
        set { vendorid = value; }
    }
    private string company_id;

    public string Company_id
    {
        get { return company_id; }
        set { company_id = value; }
    }
    private string login_id;

    public string Login_id
    {
        get { return login_id; }
        set { login_id = value; }
    }
    private DateTime creationdate;

    public DateTime Creationdate
    {
        get { return creationdate; }
        set { creationdate = value; }
    }
    private string modificationby;

    public string Modificationby
    {
        get { return modificationby; }
        set { modificationby = value; }
    }
    private DateTime modificationdate;

    public DateTime Modificationdate
    {
        get { return modificationdate; }
        set { modificationdate = value; }
    }
    private int pstatus;

    public int Pstatus
    {
        get { return pstatus; }
        set { pstatus = value; }
    }
    private string remarks = null;

    public string Remarks
    {
        get { return remarks; }
        set { remarks = value; }
    }

    //------------------------------------------Detail ------------------------------------

    private int prdid;

    public int Prdid
    {
        get { return prdid; }
        set { prdid = value; }
    }
    private float quantity;

    public float Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }
    private float unitprice;

    public float Unitprice
    {
        get { return unitprice; }
        set { unitprice = value; }
    }
    private string paymentduration;

    public string Paymentduration
    {
        get { return paymentduration; }
        set { paymentduration = value; }
    }
    private DateTime deliverydate;

    public DateTime Deliverydate
    {
        get { return deliverydate; }
        set { deliverydate = value; }
    }
    private string paymentmethod;

    public string Paymentmethod
    {
        get { return paymentmethod; }
        set { paymentmethod = value; }
    }
}

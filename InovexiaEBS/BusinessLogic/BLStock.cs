using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


    public class BLStock
    {

        public BLStock()
        { }


        public static long InsertStockDealer(BOStock objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertStockDealer(objBO));
        }

        public static long InsertStock(BOStock  objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertStock(objBO));
        }


        public static long InsertStockImport(BOStock objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertStockImport(objBO));
        }



        public static long UpdateStock(BOStock objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.UpdateStock(objBO));
        }

        public static long InsertMIOFMaster(BOMIOF  objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertMIOF(objBO));
        }
        public static long InsertMIOFDetail(BOMIOF objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertMIOFDetail(objBO));
        }

        public static long InsertProjectEstimation(BOProjectEstimation  objBO)
        {
            DAStock objDA = new DAStock();
            return Convert.ToInt64(objDA.InsertProjectEstimation (objBO));
        }
        
    }

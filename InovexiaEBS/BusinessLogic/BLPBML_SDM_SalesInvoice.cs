using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



    public class BLPBML_SDM_SalesInvoice
    {
        public static long InsertPBML_SDM_SalesInvoice(BOPBML_SDM_SalesInvoice boItem)
        {

            DAPBML_SDM_SalesInvoice objDA = new DAPBML_SDM_SalesInvoice();
            return Convert.ToInt64(objDA.InsertPBML_SDM_SalesInvoice(boItem));
        }

    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




    public class BLPBML_SDM_SRDetail
    {
        public static long InsertPBML_SDM_SRDetail(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.InsertPBML_SDM_SRDetail(boItem));
        }

        public static long insertSalesForceMasterBL(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.insertSalesForceMasterDA(boItem));
        }

        public static long insertSalesForceDetailBL(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.insertSalesForceDeatilDA(boItem));
        }



        public static long insertSalesForceFieldBL(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.insertSalesForceFieldDA(boItem));
        }

        public static long insertSalesForceDealerBL(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.insertSalesForceDealerDA(boItem));
        }


        public static long insertTerritoryDealerBL(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.insertDealerTerritoryDA(boItem));
        }


        public static long InsertSalesManCredit(BOPBML_SDM_SRDetail boItem)
        {

            DAPBML_SDM_SRDetail objDA = new DAPBML_SDM_SRDetail();
            return Convert.ToInt64(objDA.InsertPBML_SalesManCreditLimit(boItem));
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class BLChartAccounts
    {

        public BLChartAccounts()
        { }





        public static long insertAC1(BOChartAccounts  boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.insertAC1(boaddemployee));

        }

        public static long insertAC2(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.insertAC2(boaddemployee));

        }
        public static long insertAC3(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.insertAC3(boaddemployee));

        }
        public static long insertAC4(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.insertAC4(boaddemployee));

        }
        public static long insertACDetail(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.insertACDetail(boaddemployee));

        }


        public static long updateACDetail(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.updateACDetail(boaddemployee));

        }
        public static long InsertACDetailReportHead(BOChartAccounts boaddemployee)
        {
            DAChartAccounts daaddemp = new DAChartAccounts();
            return Convert.ToInt64(daaddemp.InsertACDetailReportHead(boaddemployee));

        }
    }

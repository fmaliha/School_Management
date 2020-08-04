using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class BLSchedule
    {


        public BLSchedule()
        { 
        
        }

        public static long InsertSchedule(BOSchedule   objBO)
        {
            DASchedule objDA = new DASchedule();
            return Convert.ToInt64(objDA.InsertSchedule(objBO ));
        }

        public static long InsertScheduleDetail(BOSchedule objBO)
        {
            DASchedule objDA = new DASchedule();
            return Convert.ToInt64(objDA.InsertScheduleDetail(objBO));
        }


    }

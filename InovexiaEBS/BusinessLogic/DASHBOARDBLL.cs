using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic
{
    public class DASHBOARDBLL
    {

        internal static DataTable GetStudentCount(Hashtable ht)
        {
            DASHBOARDDLL dll = new DASHBOARDDLL();

            return dll.GetStudentCount(ht);

        }

        internal static DataTable GetFeeSummary(Hashtable ht)
        {
            DASHBOARDDLL dll = new DASHBOARDDLL();

            return dll.GetFeeSummary(ht);

        }
    }
}
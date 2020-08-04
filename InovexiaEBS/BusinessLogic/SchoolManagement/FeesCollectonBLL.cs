using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.DataAccess.SchoolManagement;

namespace InovexiaEBS.BusinessLogic.SchoolManagement
{
    public class FeesCollectonBLL
    {
        internal  long SavePayment(VmStudentRegistration objvm)
    {
        FeesCollectionDLL dll = new FeesCollectionDLL();
        
        return dll.SavePayment(objvm);
    }

        internal long UpdatePayment(VmStudentRegistration objvm)
        {
            FeesCollectionDLL dll = new FeesCollectionDLL();

            return dll.UpdatePayment(objvm);
        }
    }
}
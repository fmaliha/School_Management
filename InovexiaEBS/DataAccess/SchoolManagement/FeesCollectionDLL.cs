using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using PBSConnLib;

namespace InovexiaEBS.DataAccess.SchoolManagement
{
    public class FeesCollectionDLL
    {
        PBSDBUtility pbs = new PBSDBUtility();
        internal long SavePayment(VmStudentRegistration objvm)
        {
            try
            {
                string RF = string.Empty;

                Hashtable ht= new Hashtable();

                ht.Add("StudentAdmissionNo", objvm.StudentAdmissionNo);
                ht.Add("Date", objvm.PaymentDate);
                ht.Add("CollectionHead",objvm.collectionType);
                ht.Add("CollectionMode",objvm.PaymentType);
                ht.Add("Amount",objvm.Amount);
                ht.Add("Narration",objvm.Narration);

                RF = pbs.GetDataByProc(ht, "SM_SaveFeesCollection").Rows[0]["ReferenceNo"].ToString();

                return long.Parse(RF);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }

            return 0;
        }


        internal long UpdatePayment(VmStudentRegistration objvm)
        {
            try
            {
                long result = 0;
                Hashtable ht = new Hashtable();


                ht.Add("ReferenceNo", objvm.RefNo);
                ht.Add("Date", objvm.PaymentDate);
                ht.Add("CollectionHead", objvm.collectionType);
                ht.Add("CollectionMode", objvm.PaymentType);
                ht.Add("Amount", objvm.Amount);
                ht.Add("Narration", objvm.Narration); ;

                return result = pbs.InsertData(ht, "SM_UpdateFees");

            }
            catch (Exception)
            {
                
                throw;
            }
          
        }
    }
}
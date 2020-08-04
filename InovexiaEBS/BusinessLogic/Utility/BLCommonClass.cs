using InovexiaEBS.DataAccess.Utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.BusinessLogic.Utility
{
    public class BLCommonClass
    { 
        internal static DataTable GetInstitutionMasterInfo()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstitutionMasterInfo();
        }
        internal static DataTable GetCmnMachineType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetCmnMachineType();
        }

        internal static DataTable GetInstituteProgramType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstituteProgramType();
        }
        internal static DataTable GetInstituteProgramSpecialization()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstituteProgramSpecialization();
        }

        internal static DataTable GetInstituteProgram()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstituteProgram();
        }

        internal static DataTable GetHighestEducation()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetHighestEducation();
        }
        internal static DataTable GetCountry()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetCountry();
        }

        internal static DataTable GetHrType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetHrType();
        }
        internal static DataTable GetJobType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetJobType();
        }
        internal static DataTable GetDesignation()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetDesignation();
        }

        internal static DataTable GetInstituteManagementDetails()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstituteManagementDetails();
        }

        internal static DataTable GetMeasurementUnit()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetMeasurementUnit();
        }

        internal static DataTable GetgetImportItemType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetgetImportItemType();
        }
        internal static DataTable GetComplianceType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetComplianceType();
        }
        

        internal static DataTable GetYear()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetYear();
        }

        internal static DataTable GetEnterprise(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetEnterprise(ht);
        }


        internal static DataTable GetProject(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetProject(ht);


        }
        internal static DataTable GetMinistry(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetMinistry(ht);


        }


        internal static DataTable GetAgency(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetAgency(ht);


        }

        internal static DataTable GetPlanningDept(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetPlanningDept(ht);


        }
        
        internal static DataTable GetFinancialYear(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetFinancialYear(ht);


        }

        internal static DataTable GetProjectDetailByID(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetProjectDetailByID(ht);


        }
        
        internal static DataTable GetBlogPostType()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetBlogPostType();
        }

        
        internal static DataTable GetBankInfo()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetBankInfo();
        }

        

        internal static DataTable GetDivision()
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetDivision();
        }
        internal static DataTable GetDistrictsbyDivisionID(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetDistrictsbyDivisionID(ht);
        }
        internal static DataTable GetThanabyDistrictID(Hashtable ht)
        {

            DACommonClass objDA = new DACommonClass();
            return objDA.GetThanabyDistrictID(ht);
        }




        internal static DataTable GetInstituteProgramByType(Hashtable ht)
        {
            DACommonClass objDA = new DACommonClass();
            return objDA.GetInstituteProgramByType(ht);
        }
    }
}
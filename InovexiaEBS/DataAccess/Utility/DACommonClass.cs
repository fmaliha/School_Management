using InovexiaEBS.BusinessEntity.PBML.Settings;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InovexiaEBS.DataAccess.Utility
{
    public class DACommonClass
    {
        PBSDBUtility pbsUtility = new PBSDBUtility();

        public DataTable GetInstitutionMasterInfo()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetComboInstitutionMasterInfo");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        public DataTable GetCmnMachineType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_GetComboCmnMachineType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GetInstituteProgramType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getInstituteProgramType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GetInstituteProgramSpecialization()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getInstituteProgramSpecialization");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        public DataTable GetInstituteProgram()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getInstituteProgram");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        internal DataTable GetHighestEducation()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getHighestEducation");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetCountry()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getCountry");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetHrType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getHrType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        internal DataTable GetJobType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getJobType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        internal DataTable GetDesignation()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getDesignation");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetInstituteManagementDetails()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getInstituteManagementDetails");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetMeasurementUnit()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_MeasurementUnit");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetYear()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getYear");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        internal DataTable GetEnterprise(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht,"sp_getEnterprise");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetProject(Hashtable ht)
        {
            try
            { 
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getProject");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }



        internal DataTable GetMinistry(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getMinistry");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetAgency(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getAgency");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }


        internal DataTable GetPlanningDept(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getPlanningDept");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
        

        internal DataTable GetFinancialYear(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getFinancialYear");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        
        internal DataTable GetProjectDetailByID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getProjectDetailByID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetBankInfo()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getBank");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetBlogPostType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getBlogPostType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        

        

        internal DataTable GetDivision()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getDivision");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetDistrictsbyDivisionID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getDistrictsbyDivisionID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetThanabyDistrictID(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getThanabyDistrictID");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetgetImportItemType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getImportItemType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        internal DataTable GetComplianceType()
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc("sp_getComplianceType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }




        internal DataTable GetInstituteProgramByType(Hashtable ht)
        {
            try
            {
                DataTable dataTable = pbsUtility.GetDataByProc(ht, "sp_getInstituteProgramByType");
                return dataTable;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
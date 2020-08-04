using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Web.UI.HtmlChart.PlotArea;

namespace InovexiaEBS.BusinessEntity.SchoolManagement
{
    public class VmStudentRegistration
    {
        public int    AdmissionNo      { get; set; }
        public DateTime AdmissionDate  { get; set; }
        public string sFirstName       { get; set; }
        public string MiddleName       { get; set; }
        public string sLastName        { get; set; }
        public string StudentID        { get; set; }
        public string Batch            { get; set; }
        public DateTime sDOB           { get; set; }
        public string Gender           { get; set; }
        public string Blood            { get; set; }
        public string BirthPlace       { get; set; }
        public string Nationality      { get; set; }
        public string Language         { get; set; }
        public string Religion         { get; set; }
        public string StudentCategory  { get; set; }
        public string CurrentAddress   { get; set; }
        public string PermanentAddress { get; set; }
        public string sCity            { get; set; }
        public string sState           { get; set; }
        public string sPinCode         { get; set; }
        public string sCountry         { get; set; }
        public string PhoneNumber      { get; set; }
        public string PhoneNumber2     { get; set; }
        public string sEmail           { get; set; }
        public string StudentPhoto     { get; set; }
        public string StudentDocument  { get; set; }



        //////////////           father     ///////////////////


        public string Namef  { get; set; }
        public string Nationalityf{ get; set; }
        public string Maritalstatusf { get; set; }
        public string Educationf { get; set; }
        public string Occupationf { get; set; }
        public string Organizationf { get; set; }
        public string Designationf { get; set; }
        public string Yearofservicef { get; set; }
        public string Officeaddf { get; set; }
        public string offtphonef { get; set; }
        public string residenceaddf { get; set; }
        public string preaddf { get; set; }
        public string peraddf { get; set; }
        public string tnof { get; set; }
        public string mobilef { get; set; }
        public string emailaddf { get; set; }
        public string childresidewithfather { get; set; }

                         //         Mother ///////////


        public string Namem { get; set; }
        public string Nationalitym { get; set; }
        public string Maritalstatusm { get; set; }
        public string Educationm { get; set; }
        public string Occupationm { get; set; }
        public string Organizationm { get; set; }
        public string Designationm { get; set; }
        public string Yearofservicem { get; set; }
        public string Officeaddm { get; set; }
        public string offtphonem { get; set; }
        public string residenceaddm { get; set; }
        public string preaddm { get; set; }
        public string peraddm { get; set; }
        public string tnom { get; set; }
        public string mobilem { get; set; }
        public string emailaddm { get; set; }
        public string childresidewithmother { get; set; }



        /////////////////////Guardians////  /////////////////



        
        public string nameg              { get; set; }
        public string nationalityg       { get; set; }
        public string Relationwstug      { get; set; }
        public string residenceaddg      { get; set; }
        
        public string preaddg            { get; set; }
        public string peraddg            { get; set; }
        public string tnog               { get; set; }
        public string mobilenog          { get; set; }
        public string emailg             { get; set; }



        /////////////////////Emergency Contact////  /////////////////

        public string NameE { get; set; }
        public string NationalityE { get; set; }
        public string RsWithStudent { get; set; }
        public string PresentAddressE { get; set; }
        public string PermanentAddressE { get; set; }
        public string TelephoneNoE { get; set; }
        public string MobileNoE { get; set; }
        public string EAddressE { get; set; }

        public string NameR1 { get; set; }
        public string NationalityR1 { get; set; }
        public string RsWithParentR1 { get; set; }
        public string PresentAddressR1 { get; set; }
        public string PermanentAddressR1 { get; set; }
        public string TelephoneNoR1 { get; set; }
        public string MobileNoR1 { get; set; }
        public string EAddressR1 { get; set; }

        public string NameR2 { get; set; }
        public string NationalityR2 { get; set; }
        public string RsWithParentR2 { get; set; }
        public string PresentAddressR2 { get; set; }
        public string PermanentAddressR2 { get; set; }
        public string TelephoneNoR2 { get; set; }
        public string MobileNoR2 { get; set; }
        public string EAddressR2 { get; set; }


       /// <summary>
       /// ///// educational background
       /// 
       /// </summary>
       /// 
       /// 
        public string namep { get; set; }
        public string gradep { get; set; }

        public string addschoolp { get; set; }
        public string telephonep { get; set; }
        public string emailp { get; set; }

        public DateTime attenddeddatep { get; set; }
        public string attendingcurrp { get; set; }

        //AdditionalDetails  Details tab


        //Medical Info

        public string Hasmedicalproblem { get; set; }
        public string Onmedication { get; set; }
        public string Medicaldetails { get; set; }



      
        /// Siblings Info
     
        public string sname1 { get; set; }
        public string sname2 { get; set; }
        public string sgender1 { get; set; }
        public string sgender2 { get; set; }
        public string srelationship1 { get; set; }
        public string srelationship2 { get; set; }
        public string sage1 { get; set; }
        public string sage2 { get; set; }
        public string sstudentID1 { get; set; }
        public string sstudentID2 { get; set; }
        public string sclassroll1 { get; set; }
        public string sclassroll2 { get; set; }
        public string scampus1 { get; set; }
        public string scampus2 { get; set; }


        ///Transportation 
        /// 
        /// 
        public string personalcar { get; set; }
        public string bus { get; set; }
        public string schoolbus { get; set; }
        public string carregno { get; set; }


        /// CreateBatch
        /// 
        /// 
        public string BatchID;
        public string batchname;
       public string batchyearID;
       public int batchyearf;
        public int batchyeart;
       public string batchyearName;
        public string classID;
        public string classname;
        public string batchremarks;




        /////////// Create Class


        public string ClassID { get; set; }
        public string NameClass { get; set; }
        public string SectionID { get; set; }
        public string RemarksClass { get; set; }
        public string CreatedByClass { get; set; }
        public string CreateTimeClass { get; set; }

        /////////// Subject

        public int ID { get; set; }
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }

        //////////////////Batch

        public string Student { get; set; }
        public string Bbatch { get; set; }
        public string Class { get; set; }
        public string Session { get; set; }
        


        /////////Payment
        /// 

        public string StudentAdmissionNo { get; set; }
        public DateTime PaymentDate { get; set; }
        public string RefNo { get; set; }
        public string collectionType { get; set; }
        public string PaymentType { get; set; }
        public string Amount { get; set; }
        public string Narration { get; set; }



        ///Create Fee Category 
       

        public string FeeCategory { get; set; }

        public string FeeFrequency { get; set; }




        ///Expense
        /// 
       public DateTime  Expensedate  { get; set; }
       public string  ExpenseType  { get; set; }
       public string  EPaymentType { get; set; }
       public string  EAmount      { get; set; }
       public string  ENarration   { get; set; }
       public string ExpenseCategory { get; set; }


       ///AccountreceiveableEntry
       /// 

       public string ERefNo { get; set; }
       public string EMonth { get; set; }
       public string EYear { get; set; }
       public string EPayHead { get; set; }
       
        //batchlist

       public string ClassName { get; set; }
       public string BatchClassID { get; set; }
    
    }
}
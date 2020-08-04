using IPLCriptography;
using PBSConnLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

namespace InovexiaEBS.Webservice
{


    /// <summary>
    /// Summary description for Dashboard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Dashboard : System.Web.Services.WebService
    {
        MyEncryptor objMyEncryptor = new MyEncryptor();
        int pin_num;

        [WebMethod]
        public static string LoadBarChart()
        {

            var data = new
            {
                labels = new[] { "South Western", "Western", "Northern", "North Eastern", "Eastern" },
                datasets = new[] {
            new  { label = "2016 - 2017", backgroundColor = new[] { "rgba(220, 220, 220, 0.5)" }, pointBorderColor = "#fff", data = new[] {"100","200","150","375","500"} }
            ,new  { label = "2017 - 2018", backgroundColor = new[] { "#018AC8", "#058EAA", "#DEB816", "#E37F1C", "#4A5D0E" }, pointBorderColor = "#fff", data = new[] {"122","210","175","375","525"}  }

        }
            };

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(data);
        }

        public class TransactionNumber
        {
            public string MonthName { set; get; }
            public int NumberOfTransaction { set; get; }
            public decimal TotalAmount { set; get; }
        }


        [WebMethod(EnableSession = true)]
        public List<TransactionNumber> NumberOfTransaction()
        {
            try
            {
                PBSDBUtility ABS_IDB = new PBSDBUtility();

                var NumberOfTransaction = new List<TransactionNumber>();

                DataTable dataTable = ABS_IDB.GetDataByProc("sp_GetMonthlySalesAmountAndQuantityForDashboard");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    //TransactionNumber _objNumberOfTrans = new TransactionNumber
                    //{
                    //    MonthName = dataRow["month"].ToString(),
                    //    NumberOfTransaction = int.Parse(dataRow["total"].ToString()),
                    //    TotalAmount = decimal.Parse(dataRow["totalAmount"].ToString())
                    //};
                    //NumberOfTransaction.Add(_objNumberOfTrans);
                }

                TransactionNumber _objNumberOfTrans = new TransactionNumber
                {
                    MonthName = "Jan",
                    NumberOfTransaction = 200,
                    TotalAmount = 2698
                };
                NumberOfTransaction.Add(_objNumberOfTrans);


                _objNumberOfTrans = new TransactionNumber
                {
                    MonthName = "Feb",
                    NumberOfTransaction = 180,
                    TotalAmount = 1698
                };
                NumberOfTransaction.Add(_objNumberOfTrans);

                _objNumberOfTrans = new TransactionNumber
                {
                    MonthName = "Mar",
                    NumberOfTransaction = 210,
                    TotalAmount = 3698
                };
                NumberOfTransaction.Add(_objNumberOfTrans);

                return NumberOfTransaction;
            }
            catch (Exception)
            {

                throw;
            }


        }


        [WebMethod(EnableSession = true)]
        public List<TransactionNumber> NumberOfTransactionPurchase()
        {
            try
            {
                PBSDBUtility ABS_IDB = new PBSDBUtility();

                var NumberOfTransaction = new List<TransactionNumber>();

                DataTable dataTable = ABS_IDB.GetDataByProc("sp_GetMonthlyPurchaseAmountAndQuantityForDashboard");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    TransactionNumber _objNumberOfTrans = new TransactionNumber
                    {
                        MonthName = dataRow["month"].ToString(),
                        NumberOfTransaction = int.Parse(dataRow["total"].ToString()),
                        TotalAmount = decimal.Parse(dataRow["totalAmount"].ToString())
                    };
                    NumberOfTransaction.Add(_objNumberOfTrans);
                }
                return NumberOfTransaction;
            }
            catch (Exception)
            {

                throw;
            }


        }

        public class NumberOfTransactionValueForBoxClass
        {
            public string TodaysSaleQty { set; get; }
            public decimal TodaysSaleAmount { set; get; }
            public decimal TodaysStockInQty { set; get; }
            public decimal TodaysStockOutQty { set; get; }
            public decimal TodaysStockInValue { set; get; }
            public decimal TodaysStockOutValue { set; get; }
            public decimal TotalAccountsPayable { set; get; }
            public decimal TotalAccountsReceivable { set; get; }


        }

        [WebMethod(EnableSession = true)]
        public List<NumberOfTransactionValueForBoxClass> NumberOfTransactionValueForBox()
        {
            try
            {
                PBSDBUtility ABS_IDB = new PBSDBUtility();
                var NumberOfTransactionValueForBoxClass = new List<NumberOfTransactionValueForBoxClass>();
                DataTable dataTable = ABS_IDB.GetDataByProc("sp_GetDailySalesQtyAndAmountForDashboard");
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    NumberOfTransactionValueForBoxClass _objNumberOfTrans = new NumberOfTransactionValueForBoxClass
                    {
                        TodaysSaleQty = dataRow["TodaysSaleQty"].ToString(),
                        TodaysSaleAmount = decimal.Parse(dataRow["TodaysSaleAmount"].ToString()),
                        TodaysStockInQty = decimal.Parse(dataRow["TodaysStockInQty"].ToString()),
                        TodaysStockOutQty = decimal.Parse(dataRow["TodaysStockOutQty"].ToString()),
                        TodaysStockInValue = decimal.Parse(dataRow["TodaysStockInValue"].ToString()),
                        TodaysStockOutValue = decimal.Parse(dataRow["TodaysStockOutValue"].ToString()),
                        TotalAccountsPayable = decimal.Parse(dataRow["TotalAccountsPayable"].ToString()),
                        TotalAccountsReceivable = decimal.Parse(dataRow["TotalAccountsReceivable"].ToString()),

                    };
                    NumberOfTransactionValueForBoxClass.Add(_objNumberOfTrans);
                }
                return NumberOfTransactionValueForBoxClass;
            }
            catch (Exception)
            {

                throw;
            }


        }


        /// Login Pin Check
        [WebMethod]
        public string ValidateLoginPin(string ID)
        {
            //do some code here..
            try
            {
                PBSDBUtility ABS_IDB = new PBSDBUtility();
                Hashtable ht = new Hashtable();
                ht.Add("login_id", ID);

                DataTable dataTable = ABS_IDB.GetDataByProc(ht, "spLogCheckPin");
                if (dataTable.Rows.Count > 0)
                {
                    return "1";
                }
                else
                {
                    return "0";
                }
             
            }
            catch (Exception)
            {
                return "0";
                throw;
            }
            
        }


        [WebMethod (EnableSession=true)]
        public string ValidateLoginUser(string ID, string Pin)
        {
            //do some code here..
            try
            {
                PBSDBUtility ABS_IDB = new PBSDBUtility();
                string pass = objMyEncryptor.Encrypt(Pin);
                Hashtable ht = new Hashtable();
                ht.Add("login_id", ID);
                ht.Add("password", pass);

                DataTable dataTable = ABS_IDB.GetDataByProc(ht, "spLogCheck");
                if (dataTable.Rows.Count == 1)
                {
                    pin_num = int.Parse(dataTable.Rows[0][0].ToString());

                    Session.Add(SessionInfo.pin_number, dataTable.Rows[0][0].ToString());
                    Session.Add(SessionInfo.user_name, dataTable.Rows[0][1].ToString());
                    Session.Add(SessionInfo.loginid, dataTable.Rows[0][2].ToString());
                    Session.Add(SessionInfo.UserType, dataTable.Rows[0][4].ToString());
                    //Session.Add(SessionInfo.EmployeeID, DTabLogin.Rows[0][5].ToString());
                    //Session.Add(SessionInfo.StoreID, DTabLogin.Rows[0][6].ToString());
                    //Session.Add(SessionInfo.CompanyName, DTabLogin.Rows[0][7].ToString());


                    //  HttpContext.Current.Response.Redirect("~/Dashboard.aspx");

                    var a = Session[SessionInfo.pin_number].ToString();

                    return "1";
                }
                else
                {
                    return "0";
                }

                
            }
            catch (Exception ex)
            {
                return "0";
                throw;
            }

        }

    }
}

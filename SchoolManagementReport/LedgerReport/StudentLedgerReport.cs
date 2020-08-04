namespace SchoolManagementReport.ExpenseReport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for StudentLedgerReport.
    /// </summary>
    public partial class StudentLedgerReport : Telerik.Reporting.Report
    {
        public StudentLedgerReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        public DateTime StartDate
        {
            get
            {
                return (DateTime)sqlDataSource1.Parameters[0].Value;
            }
            set
            {
                sqlDataSource1.Parameters[0].Value = value;

                
            }

        }


        public DateTime EndDate
        {
            get
            {
                return (DateTime)sqlDataSource1.Parameters[1].Value;
            }
            set
            {
                sqlDataSource1.Parameters[1].Value = value;
                


            }

        }

        public int AdmissionNo
        {
            get
            {
                return (int) sqlDataSource1.Parameters[2].Value;
            }
            set
            {
                sqlDataSource1.Parameters[2].Value = value;



            }

        }
    }
}
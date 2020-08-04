namespace SchoolManagementReport.FeesReport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    
    public partial class RptStudentFeesReceived : Telerik.Reporting.Report
    {
        public RptStudentFeesReceived()
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

                sqlDataSource2.Parameters[0].Value = value;
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
                sqlDataSource2.Parameters[1].Value = value;


            }

        }

        private void groupFooterSection_Disposed(object sender, EventArgs e)
        {

        }
    }
}
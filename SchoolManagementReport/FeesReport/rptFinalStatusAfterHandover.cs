namespace BBSReport
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for CustomerInfoRpt.
    /// </summary>
    public partial class rptFinalStatusAfterHandover : Telerik.Reporting.Report
    {
        public rptFinalStatusAfterHandover()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            
        }

        public int FnStatusID
        {
            get
            {
                return (int)sqlDataSource1.Parameters[0].Value;
            }
            set
            {
                sqlDataSource1.Parameters[0].Value = value;
            }
        }


        public DateTime sdate
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


        public DateTime edate
        {
            get
            {
                return (DateTime)sqlDataSource1.Parameters[2].Value;
            }
            set
            {
                sqlDataSource1.Parameters[2].Value = value;


            }

        }
        

    }
}
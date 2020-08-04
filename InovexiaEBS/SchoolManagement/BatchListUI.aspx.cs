using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InovexiaEBS.BusinessEntity.SchoolManagement;
using InovexiaEBS.BusinessLogic.SchoolManagement;
using Telerik.Web.UI.com.hisoftware.api2;

namespace InovexiaEBS.SchoolManagement
{
    public partial class BatchListUI : System.Web.UI.Page
    {
        StudentListBLL _objBLL = new StudentListBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowHFBatchvalues();
                ShowHFSubjectValues();


                //GetBatchGridPG();
                //GetBatchGridNursery();
                //GetBatchGridKG();
                //GetBatchGridG1();
                //GetBatchGridG2();
                //GetBatchGridG3();
                //GetBatchGridG4();
                //GetBatchGridG5();
                //GetBatchGridG6();
                //GetBatchGridG7();
                //GetBatchGridG8();
                //GetBatchGridG9();
                //GetBatchGridG10();

              

                grdbatchpg.Visible = false;
                grdbnursery.Visible = false;
                grdbKG.Visible = false;
                grdbg1.Visible = false;
                grdbG2.Visible = false;
                grdbG3.Visible = false;
                grdbG4.Visible = false;
                grdbG5.Visible = false;
                grdbG6.Visible = false;
                grdbG7.Visible = false;
                grdbG8.Visible = false;
                grdbG9.Visible = false;
                grdbG10.Visible = false;


                grdsPG.Visible = false;
                grdsnursery.Visible = false;
                grdsKG.Visible = false;
                grds1.Visible = false;
                grds2.Visible = false;
                grds3.Visible = false;
                grds4.Visible = false;
                grds5.Visible = false;
                grds6.Visible = false;
                grds7.Visible = false;
                grds8.Visible = false;
                grds9.Visible = false;
                grds10.Visible = false;


                //GetSubjectsGridPG();
                //GetSubjectsGridNursery();
                //GetSubjectsGridKG();
                //GetSubjectsGridG1();
                //GetSubjectsGridG2();
                //GetSubjectsGridG3();
                //GetSubjectsGridG4();
                //GetSubjectsGridG5();
                //GetSubjectsGridG6();
                //GetSubjectsGridG7();
                //GetSubjectsGridG8();
                //GetSubjectsGridG9();
                //GetSubjectsGridG10();
                





            }

        }

        protected void btnaddbatch_OnClick(object sender, EventArgs e)
        {
            
        }

        protected void ShowHFBatchvalues()
        {
            try
            {
                DataTable dtb = BatchListBLL.GetBatchCounts();

                if (dtb.Rows.Count > 0)
                {

                    /////batch values holding to hiddenfields  
                   
                    hfbpg.Value = dtb.Rows[0]["Batch PG"].ToString();
                    hfbnursery.Value = dtb.Rows[0]["Batch Nursery"].ToString();
                    hfbKG.Value = dtb.Rows[0]["Batch KG"].ToString();
                    hfb1.Value = dtb.Rows[0]["Batch Grade I"].ToString();
                    hfb2.Value = dtb.Rows[0]["Batch Grade II"].ToString();
                    hfb3.Value = dtb.Rows[0]["Batch Grade III"].ToString();
                    hfb4.Value = dtb.Rows[0]["Batch Grade IV"].ToString();
                    hfb5.Value = dtb.Rows[0]["Batch Grade V"].ToString();
                    hfb6.Value = dtb.Rows[0]["Batch Grade VI"].ToString();
                    hfb7.Value = dtb.Rows[0]["Batch Grade VII"].ToString();
                    hfb8.Value = dtb.Rows[0]["Batch Grade VIII"].ToString();
                    hfb9.Value = dtb.Rows[0]["Batch Grade IX"].ToString();
                    hfb10.Value = dtb.Rows[0]["Batch Grade X"].ToString();
                }

///batch from hidden field to labels assignment
/// 
                lblbPG.Text = hfbpg.Value.ToString();
                lblbnursery.Text = hfbnursery.Value.ToString();
                lblbKG.Text = hfbKG.Value.ToString();
                lblb1.Text = hfb1.Value.ToString();
                lblb2.Text = hfb2.Value.ToString();
                lblb3.Text = hfb3.Value.ToString();
                lblb4.Text = hfb4.Value.ToString();
                lblb5.Text = hfb5.Value.ToString();
                lblb6.Text = hfb6.Value.ToString();
                lblb7.Text = hfb7.Value.ToString();
                lblb8.Text = hfb8.Value.ToString();
                lblb9.Text = hfb9.Value.ToString();
                lblb10.Text = hfb10.Value.ToString();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message.ToString());
            }
        }

        

        protected void pagerstulistgrd(object sender, GridViewPageEventArgs e)
        {
            ///
        }

        protected void PGtable(object sender, EventArgs e)
        {

            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button) sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);
            //hfClassName.Value = "Play Group";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbatchpg.Visible = true;
            panelgrd1.Style["Display"] = "block";

            grdsPG.Visible = true;
            DivsPG.Style["Display"] = "block";


        }


        protected void GetGrids(VmStudentRegistration objvm)
        {
            try
            {
              DataTable a = BatchListBLL.GetSubjectBatchToGrid(objvm);

               
                if (a.Rows.Count > 0)
                {
                   
                    string name = a.Rows[0]["ClassID"].ToString();

                    if (name.Contains("12"))
                    {
                        grdbatchpg.DataSource = a;
                        grdbatchpg.DataBind();

                        grdsPG.DataSource = a;
                        grdsPG.DataBind();
                    }
                    else if (name.Contains("13"))
                    {
                        grdbnursery.DataSource = a;
                        grdbnursery.DataBind();

                        grdsnursery.DataSource = a;
                        grdsnursery.DataBind();

                    }
                    else if (name.Contains("14"))
                    {
                        grdbKG.DataSource = a;
                        grdbKG.DataBind();

                        grdsKG.DataSource = a;
                        grdsKG.DataBind();
                        
                    }

                    else if (name.Contains("1"))
                    {
                        grdbg1.DataSource = a;
                        grdbg1.DataBind();

                        grds1.DataSource = a;
                        grds1.DataBind();
                    }

                    else if (name.Contains("2"))
                    {
                        grdbG2.DataSource = a;
                        grdbG2.DataBind();

                        grds2.DataSource = a;
                        grds2.DataBind();
                    }
                    else if (name.Contains("3"))
                    {
                        grdbG3.DataSource = a;
                        grdbG3.DataBind();

                        grds3.DataSource = a;
                        grds3.DataBind();
                    }
                    else if (name.Contains("4"))
                    {
                        grdbG4.DataSource = a;
                        grdbG4.DataBind();

                        grds4.DataSource = a;
                        grds4.DataBind();
                    }
                    else if (name.Contains("5"))
                    {
                        grdbG5.DataSource = a;
                        grdbG5.DataBind();

                        grds5.DataSource = a;
                        grds5.DataBind();
                    }
                    else if (name.Contains("6"))
                    {
                        grdbG6.DataSource = a;
                        grdbG6.DataBind();

                        grds6.DataSource = a;
                        grds6.DataBind();
                    }
                    else if (name.Contains("7"))
                    {
                        grdbG7.DataSource = a;
                        grdbG7.DataBind();

                        grds7.DataSource = a;
                        grds7.DataBind();
                    }
                    else if (name.Contains("8"))
                    {
                        grdbG8.DataSource = a;
                        grdbG8.DataBind();

                        grds8.DataSource = a;
                        grds8.DataBind();
                    }
                    else if (name.Contains("9"))
                    {
                        grdbG9.DataSource = a;
                        grdbG9.DataBind();

                        grds9.DataSource = a;
                        grds9.DataBind();
                    }
                    else if (name.Contains("10"))
                    {
                        grdbG10.DataSource = a;
                        grdbG10.DataBind();

                        grds10.DataSource = a;
                        grds10.DataBind();
                    }


                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }
        protected void nurerytable(object sender, EventArgs e)
        {

            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);
            //hfClassName.Value = "Nursery";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbnursery.Visible = true;
            panelgrd2.Style["Display"] = "block";


            grdsnursery.Visible = true;
            Divsnursery.Style["Display"] = "block";
        }

        protected void KGbtable(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "KG";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbKG.Visible = true;
            panelgrd3.Style["Display"] = "block";


            grdsKG.Visible = true;
            DivsKG.Style["Display"] = "block";
        }

        protected void btable1(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade I";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);


            grdbg1.Visible = true;
            panelgrd4.Style["Display"] = "block";

            grds1.Visible = true;
            Divs1.Style["Display"] = "block";
        }
        protected void btable2(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade II";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbG2.Visible = true;
            panelgrd5.Style["Display"] = "block";


            grds2.Visible = true;
            Divs2.Style["Display"] = "block";
        }

        protected void btable3(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade III";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbG3.Visible = true;
            panelgrd6.Style["Display"] = "block";

            grds3.Visible = true;
            Divs3.Style["Display"] = "block";
        }
        protected void btable4(object sender, EventArgs e)
        {

            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade IV";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);

            grdbG4.Visible = true;
            panelgrd7.Style["Display"] = "block";

            grds4.Visible = true;
            Divs4.Style["Display"] = "block";
        }

        protected void btable5(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade V";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);


            grdbG5.Visible = true;
            panelgrd8.Style["Display"] = "block";

            grds5.Visible = true;
            Divs5.Style["Display"] = "block";
        }

        protected void btable6(object sender, EventArgs e)
        {

            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade VI";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);


            grdbG6.Visible = true;
            panelgrd9.Style["Display"] = "block";

            grds6.Visible = true;
            Divs6.Style["Display"] = "block";
        }
        protected void btable7(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade VII";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);


            grdbG7.Visible = true;
            panelgrd10.Style["Display"] = "block";


            grds7.Visible = true;
            Divs7.Style["Display"] = "block";
        }
        protected void btable8(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade VIII";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);


            grdbG8.Visible = true;
            panelgrd11.Style["Display"] = "block";

            grds8.Visible = true;
            Divs8.Style["Display"] = "block";
        }
        protected void btable9(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade IX";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);
            
            grdbG9.Visible = true;
            panelgrd12.Style["Display"] = "block";

            grds9.Visible = true;
            Divs9.Style["Display"] = "block";
        }

        protected void btable10(object sender, EventArgs e)
        {
            VmStudentRegistration objvm = new VmStudentRegistration();

            Button btn = (Button)sender;
            objvm.BatchClassID = btn.CommandArgument.ToString();
            GetGrids(objvm);

            //hfClassName.Value = "Grade X";
            //objvm.ClassName = hfClassName.Value;
            //GetClasssDetails(objvm);
            
            grdbG10.Visible = true;
            panelgrd13.Style["Display"] = "block";


            grds10.Visible = true;
            Divs10.Style["Display"] = "block";
        }

       
       
        //subjects 


        protected void ShowHFSubjectValues()
        {
            try
            {
                DataTable dtb = BatchListBLL.GetSubjectsCounts();

                if (dtb.Rows.Count > 0)
                {

                    /////Sections values holding to hiddenfields  

                    hfspg.Value = dtb.Rows[0]["Section PG"].ToString();
                    hfsursery.Value = dtb.Rows[0]["Section Nursery"].ToString();
                    hfsKG.Value = dtb.Rows[0]["Section KG"].ToString();
                    hfs1.Value = dtb.Rows[0]["Section Grade I"].ToString();
                    hfs2.Value = dtb.Rows[0]["Section Grade II"].ToString();
                    hfs3.Value = dtb.Rows[0]["Section Grade III"].ToString();
                    hfs4.Value = dtb.Rows[0]["Section Grade IV"].ToString();
                    hfs5.Value = dtb.Rows[0]["Section Grade V"].ToString();
                    hfs6.Value = dtb.Rows[0]["Section Grade VI"].ToString();
                    hfs7.Value = dtb.Rows[0]["Section Grade VII"].ToString();
                    hfs8.Value = dtb.Rows[0]["Section Grade VIII"].ToString();
                    hfs9.Value = dtb.Rows[0]["Section Grade IX"].ToString();
                    hfs10.Value = dtb.Rows[0]["Section Grade X"].ToString();
                }

                ///Section from hidden field to labels assignment
                /// 
                lblsPG.Text = hfspg.Value.ToString();
                lblsnursery.Text = hfsursery.Value.ToString();
                lblsKG.Text = hfsKG.Value.ToString();
                lbls1.Text = hfs1.Value.ToString();
                lbls2.Text = hfs2.Value.ToString();
                lbls3.Text = hfs3.Value.ToString();
                lbls4.Text = hfs4.Value.ToString();
                lbls5.Text = hfs5.Value.ToString();
                lbls6.Text = hfs6.Value.ToString();
                lbls7.Text = hfs7.Value.ToString();
                lbls8.Text = hfs8.Value.ToString();
                lbls9.Text = hfs9.Value.ToString();
                lbls10.Text = hfs10.Value.ToString();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        
      

        //protected void Btn_EditBatch(object sender, EventArgs e)
        //{
        //    int BatchID = int.Parse((sender as LinkButton).CommandArgument);
        //    Response.Redirect("BatchEditUI.aspx?BatchID=" + BatchID);

            
        //}


        protected void Btn_DeleteBatch(object sender, EventArgs e)
        {
            try
            {

                int BatchID = int.Parse((sender as LinkButton).CommandArgument);
                DeleteBatchID(BatchID);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message.ToString());
            }
        }

        private void DeleteBatchID(int BatchID)
        {
            VmStudentRegistration _objVmStudentRegistration = new VmStudentRegistration();
            _objVmStudentRegistration.BatchID = BatchID.ToString();
            long i = BatchListBLL.DeleteBatch(_objVmStudentRegistration);
            if (i > 0)
            {
                //GetBatchGridPG();
                //GetBatchGridNursery();
                //GetBatchGridKG();
                //GetBatchGridG1();
                //GetBatchGridG2();
                //GetBatchGridG3();
                //GetBatchGridG4();
                //GetBatchGridG5();
                //GetBatchGridG6();
                //GetBatchGridG7();
                //GetBatchGridG8();
                //GetBatchGridG9();
                //GetBatchGridG10();
            }
        }
    }
}
<%@ Page Title="Dashboard | InovexiaEBS" Language="C#" MasterPageFile="~/InvexiaMaster.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" 
    Inherits="InovexiaEBS.Dashboard" %>


   




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <link href="<%=ResolveUrl("~/css/dashboard.css")%>" rel="stylesheet" type="text/css"/>
    
    <style>
    .panel-heading:hover {
        /* color:#FFF !important; */
        color: #000 !important;
    }

    .panel-footer:hover {
        /* color:#FFF !important; */
        color: #000 !important;
    }

    .panel-footer {
        background-color: #356aa0 !important;
    }

    .huge {
        font-size: 11px;
    }

    .panel-heading {
        height: 87px;
    }

    .x_panel {
        position: relative;
        width: 100%;
        margin-bottom: 10px;
        padding: 10px 17px;
        display: inline-block;
        background: #fff;
        border: 1px solid #E6E9ED;
        -webkit-column-break-inside: avoid;
        -moz-column-break-inside: avoid;
        column-break-inside: avoid;
        opacity: 1;
        -moz-transition: all .2s ease;
        -o-transition: all .2s ease;
        -webkit-transition: all .2s ease;
        -ms-transition: all .2s ease;
        transition: all .2s ease;
    }

    .label {
        padding: 7px 7px !important;
        /* text-transform: uppercase !important; */
        /* font-size: 8px !important; */
        font-weight: normal;
        letter-spacing: 1px;
        text-transform: capitalize !important;
    }

    .dt-buttons.btn-group .btn {
        font-size: 12px;
    }

    button.dt-button {
        background-image: none !important;
        color: #fff !important;
        background-color: #40d2ad !important;
        border-color: #40d2ad !important;
    }

        button.dt-button:hover {
            background-image: none !important;
            color: #fff !important;
            background-color: #38bb9c !important;
            border-color: #38bb9c !important;
        }

    table.dataTable.no-footer {
        border-bottom: 0px solid #111 !important;
    }

    .action-link a {
        text-decoration: none;
    }

    div#sidebar-menu {
        margin: 0;
        padding: 0;
        float: left;
        width: 100%;
    }


    .nav.side-menu li a {
        margin-bottom: 0 !important;
        cursor: pointer;
    }


    .tile_stats_count .count {
        margin: 10px 0 0 5px;
    }

    .tile_count .tile_stats_count {
        padding: 0 7%;
    }


    .x_panel {
        padding: 0 !important;
        border-radius: 3px !important;
        border: 0 !important;
        margin-bottom: 25px;
    }

    .x_content {
        padding: 15px;
    }


    .x_title {
        padding: 5px 10px;
        background: #48e2be;
        color: #fff;
        font-weight: bold;
        border: 0;
        border-top-left-radius: 3px;
        border-top-right-radius: 3px;
        /*background-image: linear-gradient(60deg, #33d1ac 0%, rgba(247, 15, 15, 0.6) 100%);*/
        background-image: linear-gradient(to right, rgb(0, 213, 230) 10%, rgb(31, 114, 162) 100%);
    }
    

        .x_title h2 {
            padding: 5px;
        }


    .x_title {
        border-bottom: 2px solid #E6E9ED;
        padding: 1px 5px 6px;
        margin-bottom: 10px;
    }

        .x_title .filter {
            width: 40%;
            float: right;
        }

        .x_title h2 {
            margin: 5px 0 6px;
            float: left;
            display: block;
            text-overflow: ellipsis;
            overflow: hidden;
            white-space: nowrap;
        }

            .x_title h2 small {
                margin-left: 10px;
            }

        .x_title span {
            color: #BDBDBD;
        }

    .x_content {
        padding: 0 5px 6px;
        position: relative;
        width: 100%;
        float: left;
        clear: both;
        margin-top: 5px;
    }

        .x_content h4 {
            font-size: 16px;
            font-weight: 500;
        }
</style>

      <script src="<%=ResolveUrl("~/js/jquery-1.11.2.min.js")%>"></script>
    
    <script src="<%=ResolveUrl("~/js/demo/chartdashboard.js")%>"></script>


  



    <script>

        $(function () {
           // $.noConflict();

            TotalSalesAmountForMonth = [];
            NumberOfTransaction = [];
            MonthNames = [];

            $.ajax({
                type: "POST",
             
                url:"<%=ResolveUrl("~/Webservice/Dashboard.asmx/NumberOfTransaction")%>",
                data: "{}",
                contentType: "application/json",
                async: false,
                success: function (data) {
                    $.each(data.d, function (key, value) {
                        MonthNames.push(value.MonthName);
                        TotalSalesAmountForMonth.push(value.TotalAmount);
                        NumberOfTransaction.push(value.NumberOfTransaction);

                    });

                    debugger;
                },
                error: function (result) {
                    debugger
                    alert("Error");
                }
            });

            var ctx2 = document.getElementById("salesChartQty").getContext("2d");
            
            var myChart = new Chart(ctx2, {
                type: 'line',
                data: {
                    labels: MonthNames,
                    datasets: [{
                        label: 'Number of Students (Public)',
                        data: NumberOfTransaction,
                        backgroundColor: "#02cee1"
                    }]
                }
            });
             

            ctx2 = document.getElementById("salesChartAmount").getContext("2d");

            var myChart = new Chart(ctx2, {
                type: 'line',
                data: {
                    labels: MonthNames,
                    datasets: [{
                        label: 'Number Of Students(Private)',
                        data: TotalSalesAmountForMonth,
                        backgroundColor: "rgba(247, 15, 15, 0.6)"
                    }]
                }
            });

            // **********   Purchase chart start
            TotalPurchaseAmountForMonth = [];
            NumberOfTransactionPurchase = [];
            MonthNamesPurchase = [];

            $.ajax({
                type: "POST",
                url: "<%=ResolveUrl("~/Webservice/Dashboard.asmx/NumberOfTransactionPurchase")%>",
               
                data: "{}",
                contentType: "application/json",
                async: false,
                success: function (data) {
                    $.each(data.d, function (key, value) {
                        MonthNamesPurchase.push(value.MonthName);
                        TotalPurchaseAmountForMonth.push(value.TotalAmount);
                        NumberOfTransactionPurchase.push(value.NumberOfTransaction);


                    });

                    debugger;
                },
                error: function (result) {
                    debugger
                    alert("Error");
                }
            });

            var ctx2 = document.getElementById("purchaseChartQty").getContext("2d");

            var myChart = new Chart(ctx2, {
                type: 'bar',
                data: {
                    labels: MonthNamesPurchase,
                    datasets: [{
                        label: 'Number of Engaged HR',
                        data: NumberOfTransactionPurchase,
                        backgroundColor: "#FFB848"
                    }]
                }
            });


            ctx2 = document.getElementById("purchaseChartAmount").getContext("2d");

            var myChart = new Chart(ctx2, {
                type: 'bar',
                data: {
                    labels: MonthNamesPurchase,
                    datasets: [{
                        label: 'Number of Required HR',
                        data: TotalPurchaseAmountForMonth,
                        backgroundColor: "#94B86E"
                    }]
                }
            });

            // **********  Finish Purchase chart start

            /// ****************   To Handle the box part data  *************** 
            $.ajax({
                type: "POST",

                url: "<%=ResolveUrl("~/Webservice/Dashboard.asmx/NumberOfTransactionValueForBox")%>",
             
                data: "{}",
                contentType: "application/json",
                async: false,
                success: function (data) {
                    $.each(data.d, function (key, value) {
                        debugger;
                        $("#saleQty").text(value.TodaysSaleQty);
                        $("#saleValue").text(value.TodaysSaleAmount);
                        $("#stockInQty").text(value.TodaysStockInQty);
                        $("#stockOutQty").text(value.TodaysStockOutQty);

                        $("#stockInValue").text(value.TodaysStockInValue);
                        $("#stockOutValue").text(value.TodaysStockOutValue);
                        $("#accountsPayable").text(value.TotalAccountsPayable);
                        $("#accountsReceivable").text(value.TotalAccountsReceivable);
                        //MonthNames.push(value.MonthName);

                    });

                    debugger;
                },
                error: function (result) {
                    debugger
                    alert("Error");
                }
            });
            /// **************** Finish  To Handle the box part data  *************** 
        });

    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="row row-bg">
            <!-- .row-bg -->
            <div class="col-sm-6 col-md-3">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual cyan">
                            #
                        </div>
                        <div class="title">Total Institute:</div>
                        <div class="value">450</div>
                       
                    </div>
                </div> <!-- /.smallstat -->
            </div> <!-- /.col-md-3 -->
            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual yellow">
                            #
                        </div>
                        <div class="title">Public Institute (Bsc):</div>
                        <div class="value">12</div>
                        
                    </div>
                </div> <!-- /.smallstat -->
            </div> <!-- /.col-md-3 -->

            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual green">
                            #
                        </div>
                        <div class="title">Private Institute (Bsc):</div>
                        <div class="value">37</div>

                    </div>
                </div>
            </div> 
            

            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual red">
                            #
                        </div>
                        <div class="title">Total Students yearly(Intake Bsc):</div>
                        <div class="value">8045</div>

                    </div>
                </div> <!-- /.smallstat -->
            </div>
        </div> <!-- /.row -->


    <div class="row row-bg">
            <!-- .row-bg -->
            <div class="col-sm-6 col-md-3">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual cyan">
                            #
                        </div>
                        <div class="title">Total Enterprise:</div>
                        <div class="value">785</div>
                       
                    </div>
                </div> <!-- /.smallstat -->
            </div> <!-- /.col-md-3 -->
            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual yellow">
                            #
                        </div>
                        <div class="title">Total HR (Engaged):</div>
                        <div class="value">76854</div>
                        
                    </div>
                </div> <!-- /.smallstat -->
            </div> <!-- /.col-md-3 -->

            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual green">
                            #
                        </div>
                        <div class="title">Total HR (Required):</div>
                        <div class="value">5236</div>

                    </div>
                </div>
            </div> 
            

            <div class="col-sm-6 col-md-3 ">
                <div class="statbox widget box box-shadow">
                    <div class="widget-content">
                        <div class="visual red">
                            #
                        </div>
                        <div class="title">Total HR (Foreign):</div>
                        <div class="value">8254</div>

                    </div>
                </div> <!-- /.smallstat -->
            </div>
        </div> <!-- /.row -->
          
         <div id="content1">
            <div style="padding-top:10px;">
                <div class="row">


                    <div class="col-lg-12 col-md-12">
                        <div class="x_panel">
                            <div class="x_title" style="max-height: 40px;">
                                <h4><i class="fa fa-bar-chart fa-fw"></i> Monthly Graduation </h4>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div class="row tile_count">
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <canvas id="salesChartQty" height="140"></canvas>
                                    </div>

                                    <div class="col-lg-6 col-lg-6 col-sm-6">
                                        <canvas id="salesChartAmount" height="140"></canvas>
                                    </div>

                                </div>
                            </div>


                        </div>


                    </div>
                </div>

                <div class="row">


                    <div class="col-lg-12 col-md-12">
                        <div class="x_panel">
                            <div class="x_title" style="max-height: 40px;">
                                <h4><i class="fa fa-bar-chart fa-fw"></i> Monthly HR </h4>
                                <div class="clearfix"></div>
                            </div>
                            <div class="x_content">
                                <div class="row tile_count">
                                    <div class="col-lg-6 col-md-6 col-sm-6">
                                        <canvas id="purchaseChartQty" height="140"></canvas>
                                    </div>

                                    <div class="col-lg-6 col-lg-6 col-sm-6">
                                        <canvas id="purchaseChartAmount" height="140"></canvas>
                                    </div>

                                </div>
                            </div>


                        </div>


                    </div>
                </div>

               

            </div>
        </div>              
    
</asp:Content>

<%@ Page Language="C#" CodeBehind="frm_MSE_IND_UTE.aspx.cs" Inherits="Web_Ruoli_frm_MSE_IND_UTE" AutoEventWireup="True" EnableEventValidation="false" %>

<%@ Register TagPrefix="uc4" TagName="Script" Src="../Common/Script.ascx" %>

<!DOCTYPE html>
<html lang="en">
<head id="headEditor" runat="server">
    <link rel="icon" type="image/png" sizes="16x16" href="../assets/images/favicon.png">
    <title>Editor Indirizzi</title>

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>

<body id="mseSrv" class="fix-header fix-sidebar card-no-border">
    <div id="main-wrapper">

        <form id="form1" runat="server" submitdisabledcontrols="true" novalidate autocomplete="off">

            <!-- ============================================================== -->
            <!-- Page wrapper  -->
            <!-- ============================================================== -->
            <div class="page-wrapper">

                <!-- ============================================================== -->
                <!-- Container fluid  -->
                <!-- ============================================================== -->
                <div class="container-fluid container-big">

                    <!-- ============================================================== -->
                    <!-- Start Page Content -->
                    <!-- ============================================================== -->

                    <%--<asp:ScriptManager ID="CustomScriptManager" runat="server" EnablePartialRendering="false" LoadScriptsBeforeUI="true" EnablePageMethods="true" CombineScripts="false"></asp:ScriptManager>--%>


                    <asp:ScriptManager ID="ScriptManager" runat="server" EnablePartialRendering="true" EnablePageMethods="true" ScriptMode="Release" LoadScriptsBeforeUI="false"></asp:ScriptManager>

                    <div class="row">

                        <div class="col-lg-12">

                            <div class="card">
                                <div class="row">
                                    <div class="col-md-6">
                                        <h3 runat="server" id="LabelTitolo"></h3>
                                    </div>
                                    <div class="col-md-6">
                                        <asp:Button ID="ButtonAnnulla" CssClass="btn btn-secondary m-l-5 pull-right" runat="server" UseSubmitBehavior="False" OnClientClick="parent.$('#ButtonIndirizzi').click();parent.$('#ButtonUtenti').click(); closeParentModal();" />
                                        <asp:Button ID="ButtonSalva" CssClass="btn btn-success pull-right" runat="server" OnClick="ButtonSalva_Click" />
                                    </div>
                                </div>

                                <hr />

                                <div class="card-body">


                                    <div id="divIndirizzo" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_indirizzo" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="controls">
                                                    <input id="Text_Indirizzo" type="text" runat="server" class="form-control required" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="divNumeroCivico" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_numero_civico" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="controls">
                                                    <input id="Text_numero_civico" type="text" runat="server" class="form-control required" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="div_tipologia_indirizzo" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_tipologia_indirizzo" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="controls">
                                                    <asp:DropDownList ID="Dropdown_tipologia_indirizzo" runat="server" class="form-control custom-select required">
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="div_attivo" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_attivo" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="col-md-8">
                                                    <div class="controls">
                                                        <asp:CheckBox ID="CheckBox_attivo" runat="server" disabled="disabled" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="div_data_disattivazione" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_data_disattivazione" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="controls">
                                                    <asp:TextBox runat="server" ID="ute_data_nascita" CssClass="form-control datepicker  col-sm-8"></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div id="div_note" runat="server" class="col-md-12">
                                        <div class="row form-group">
                                            <label id="Label_note" runat="server" class="control-label col-md-4"></label>
                                            <div class="col-md-8">
                                                <div class="controls">
                                                    <input id="Text_note" type="text" runat="server" class="form-control" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>

                    <!-- ============================================================== -->
                    <!-- End PAge Content -->
                    <!-- ============================================================== -->

                </div>
                <!-- ============================================================== -->
                <!-- End Container fluid  -->
                <!-- ============================================================== -->

            </div>

            <!-- ============================================================== -->
            <!-- End Page wrapper  -->
            <!-- ============================================================== -->

        </form>

    </div>
    <!-- ============================================================== -->
    <!-- End Wrapper -->
    <!-- ============================================================== -->

    <uc4:Script ID="Script" runat="server"></uc4:Script>
</body>
</html>

<script type="text/javascript" src="../Jscript/jquery.validate.js"></script>
<script type="text/javascript" src="../Jscript/jquery.formobserver.js"></script>

<script type="text/javascript">

    $(document).ready(function () {

        documentReadyEditorBO();

        //$('#form1').validate({
        //    errorPlacement: function (error, element) { }
        //});

        //$('#form1').FormObserve({
        //    changeClass: "changed"
        //});


    });


</script>


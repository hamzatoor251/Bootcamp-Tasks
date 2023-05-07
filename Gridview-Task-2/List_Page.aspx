<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List_Page.aspx.cs" Inherits="Gridview_Assign_2.List_Page" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css" integrity="sha384-xOolHFLEh07PJGoPkLv1IbcEPTNtaed2xpHsD9ESMhqIYd0nLMwNLD69Npy4HI+N" crossorigin="anonymous"/>
    <script>
        function ValidSearch() {
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2 class="auto-style1">List Page of Employees</h2>
            <h5 >Search Memebr: </h5>
            <asp:TextBox runat="server" id="search" placeholder="Search member name...."></asp:TextBox>
            <asp:Button runat="server" ID="callSearch" Text="Search" OnClick="callSearch_Click"/>
            <asp:Button runat="server" ID="backCall" Text="Back" OnClick="backCall_Click"/>

            <asp:Label runat="server" ID="result"></asp:Label>
            <asp:gridview  id="Satffgrid" runat="server" backcolor="White" bordercolor="#E7E7FF"

            borderstyle="None" borderwidth="1px"  AlternatingRowStyle-BorderWidth="2px" cellpadding="3" font-names="Calibri" font-size="Larger"

            gridlines="Horizontal"  AllowPaging="true" OnPageIndexChanging="GridView_PageIndexChanging" PageSize="15" DataKeyNames="ID" OnRowEditing="Satffgrid_RowEditing" OnRowCancelingEdit="Satffgrid_RowCancelingEdit" OnRowUpdating="Satffgrid_RowUpdating" OnRowDeleting="Satffgrid_RowDeleting" OnRowDataBound="Satffgrid_RowDataBound">
            
            <AlternatingRowStyle BackColor="#F7F7F7" />

            <FooterStyle BackColor="#B5C7EE" ForeColor="#4A3C88" />

            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />

            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />

            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />

            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />

            <SortedAscendingCellStyle BackColor="#F4F4FD" />

            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />

            <SortedDescendingCellStyle BackColor="#D8D8F0" />

            <SortedDescendingHeaderStyle BackColor="#3E3277" />
            <Columns>
                <asp:CommandField ShowEditButton="true" />  
                <asp:CommandField ShowDeleteButton="true" />
                
            </Columns>

        </asp:gridview>
            
        </div>
    </form>
</body>
</html>

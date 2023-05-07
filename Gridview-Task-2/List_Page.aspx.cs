using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview_Assign_2
{
    public partial class List_Page : System.Web.UI.Page
    {
        public List<StaffMember> newStaff { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack && Session["Member"]==null)
            {
                this.sessionGrid();
                this.BindGrid();
            }
            else
            {
                this.BindGrid();
            }

        }
        public class StaffMember
        {
            public int Rndmnum()
            {
                Random rnd = new Random();
                int rndID = rnd.Next(00, 99);
                return rndID;
            }
            //public List<StaffMember> newStaff = new List<StaffMember>();
            public string Name { get; set; }
            public string ID { get; set; }
            public string Address { get; set; }
            public List<StaffMember> MakeEmp()
            {
                List<StaffMember> newStaff = new List<StaffMember>();
                newStaff.Add(new StaffMember() { Name = "Ali", ID = $"01{Rndmnum()}", Address = "Founder" });
                newStaff.Add(new StaffMember() { Name = "Ahmad", ID = $"02{Rndmnum()}", Address = "CEO" });
                newStaff.Add(new StaffMember() { Name = "Ghufi", ID = $"03{Rndmnum()}", Address = "BOD" });
                newStaff.Add(new StaffMember() { Name = "Ibi", ID = $"04{Rndmnum()}", Address = "BOD" });
                newStaff.Add(new StaffMember() { Name = "Haday", ID = $"05{Rndmnum()}", Address = "Staff Manager" });
                newStaff.Add(new StaffMember() { Name = "Iram", ID = $"06{Rndmnum()}", Address = "Branch Manager" });
                newStaff.Add(new StaffMember() { Name = "Rida", ID = $"07{Rndmnum()}", Address = "Branch Manager" });
                newStaff.Add(new StaffMember() { Name = "Tahir", ID = $"08{Rndmnum()}", Address = "HR Manager" });
                newStaff.Add(new StaffMember() { Name = "Bilal", ID = $"09{Rndmnum()}", Address = "HR Manager" });
                newStaff.Add(new StaffMember() { Name = "Moadib", ID = $"10{Rndmnum()}", Address = "Associate SA" });
                newStaff.Add(new StaffMember() { Name = "Nasir", ID = $"11{Rndmnum()}", Address = "Associate SA" });
                newStaff.Add(new StaffMember() { Name = "Osama", ID = $"12{Rndmnum()}", Address = "Associate SA" });
                newStaff.Add(new StaffMember() { Name = "Roshan", ID = $"13{Rndmnum()}", Address = "Senior .Net Dev" });
                newStaff.Add(new StaffMember() { Name = "Awais", ID = $"14{Rndmnum()}", Address = "Senior .Net Dev" });
                newStaff.Add(new StaffMember() { Name = "Kazim", ID = $"15{Rndmnum()}", Address = "Senior .Net Dev" });
                newStaff.Add(new StaffMember() { Name = "Numan", ID = $"16{Rndmnum()}", Address = "Senior Mern dev" });
                newStaff.Add(new StaffMember() { Name = "Raza", ID = $"17{Rndmnum()}", Address = "Senior Mern dev" });
                newStaff.Add(new StaffMember() { Name = "Omer", ID = $"18{Rndmnum()}", Address = "Senior Mern dev" });
                newStaff.Add(new StaffMember() { Name = "Ashraf", ID = $"19{Rndmnum()}", Address = "Bussiner Development" });
                newStaff.Add(new StaffMember() { Name = "Asaad", ID = $"20{Rndmnum()}", Address = "Bussiner Development" });
                newStaff.Add(new StaffMember() { Name = "Majid", ID = $"21{Rndmnum()}", Address = "Bussiner Development" });
                newStaff.Add(new StaffMember() { Name = "Awais", ID = $"22{Rndmnum()}", Address = "Senior Mean dev" });
                newStaff.Add(new StaffMember() { Name = "Hadir", ID = $"23{Rndmnum()}", Address = "Senior Mean dev" });
                newStaff.Add(new StaffMember() { Name = "Atif", ID = $"24{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Abdullah", ID = $"25{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Shaukat", ID = $"26{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Butt", ID = $"27{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Burhan", ID = $"28{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Azeem", ID = $"29{Rndmnum()}", Address = "Full stack dev" });
                newStaff.Add(new StaffMember() { Name = "Sikander", ID = $"30{Rndmnum()}", Address = "Full stack dev" });

                return newStaff;
            }


        }
        public void sessionGrid()
        {
            List<StaffMember> makeList = new StaffMember().MakeEmp();
            Session["Member"] = makeList;
            List<StaffMember> retList = Session["Member"] as List<StaffMember>;
            //return retList;

        }
        public void BindGrid()
        {
            Satffgrid.DataSource = Session["Member"] as List<StaffMember>;
            Satffgrid.DataBind();
        }
        protected void GridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Satffgrid.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        public void callSearch_Click(object sender, EventArgs e)
        {
            List<StaffMember> filter = new List<StaffMember>();
            foreach (var i in Session["Member"] as List<StaffMember>)
            {
                if ((i.Name.ToLower() == search.Text.ToLower()) || i.ID.ToLower()==search.Text.ToLower() || i.Address.ToLower()==search.Text.ToLower())
                {
                    filter.Add(i);
                }
            }
            Satffgrid.DataSource = filter;
            Satffgrid.DataBind();
        }

        protected void Satffgrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Satffgrid.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void Satffgrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Satffgrid.EditIndex = -1;
            BindGrid();
        }

        protected void Satffgrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            List<StaffMember> updateGrid = new List<StaffMember>();
            //updateGrid.Add(e.RowIndex);
            //Session["Member"] = updateGrid;
            //BindGrid();
            TextBox name = (TextBox)Satffgrid.Rows[e.RowIndex].FindControl("Name") as TextBox;
            TextBox address = (TextBox)Satffgrid.Rows[e.RowIndex].FindControl("Address") as TextBox;
            //updateGrid.Add(name.Text);
            //updateGrid.Add(address.Text);
            //Session["Member"] = updateGrid;
            BindGrid();
        }

        protected void Satffgrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Session["Member"] != null)
            {
                List<StaffMember> newGrid = Session["Member"] as List<StaffMember>;
                newGrid.RemoveAt(e.RowIndex);
                Session["Member"] = newGrid;
                BindGrid();
            }

        }

        protected void Satffgrid_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick ", String.Format("window.location='Detail_Page.aspx&name'+(Session['Member'] as List<StaffMember>)"));
            }
        }

        protected void backCall_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
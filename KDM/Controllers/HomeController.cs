using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Microsoft.Reporting.WebForms;
using KDM.Helpers;

namespace KDM.Controllers
{
    public class HomeController : Controller
    {
        KDMDB db = new KDMDB();
        // GET: Home
        //public ActionResult Index()
        //{
        //    DataSet ds = new DataSet();
        //    DataTable table = new DataTable("DataTable");
        //    DataColumn col1 = new DataColumn("EmployeeId");
        //    DataColumn col2 = new DataColumn("FirstName");
        //    table.Columns.Add(col1);
        //    table.Columns.Add(col2);

        //    var data = db.tbl_employees.Select(x => x).ToList();
        //    foreach(var rw in data)
        //    {
        //        table.Rows.Add(rw.EmployeeId, rw.FirstName);
        //    }

        //    ds.Tables.Add(table);
        //    Session["ReportDataSet"] = ds;
        //    Session["Report"] = "~/Reports/Employee/Report1.rdlc";
        //    //return View();

        //    return Redirect("~/Reports/ReportViewer.aspx");
        //}

        public ActionResult Test()
        {
            IdentityManager im = new IdentityManager();
            string userId = im.GetUserIdByName("admin");
            im.DirectResetPassword(userId, "Admin#1234");
            return View();
        }

        [HttpPost]
        public ActionResult Test(DateTime time)
        {

            string t = String.Format("{0:hh:mm}", time);


            // or save time variable 
            return View();
        }

        public FileResult PdfReport()
        {
            //ControllerContext context = ReportHelper.CreateController<HomeController>().ControllerContext;
            
            return ReportHelper.ResponseAsPDF(this.ControllerContext, "Test");
        }

        //public ActionResult GetRawResponse(string id)
        //{
        //    List<tbl_employees> model = new List<tbl_employees>();
        //    if (!String.IsNullOrWhiteSpace(id))
        //    {
        //        model = db.tbl_employees.Where(x => x.EmployeeId == id).Select(x => x).ToList();

        //    }
        //    ControllerContext context = ReportHelper.CreateController<EmployeeController>().ControllerContext;
        //    string html = ReportHelper.RenderViewToString(context, "ReportEmployeeDetails", model);
            
        //    return Content(html);
        //}

    }
}
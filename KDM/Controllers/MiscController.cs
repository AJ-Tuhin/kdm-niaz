using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace KDM.Controllers
{
    public class MiscController:Controller
    {
     
        
        public JsonResult LoadControllers(string id)
        {
            using (KDMDB db = new KDMDB())
            {
                var items = db.tbl_controllers.Where(x=>x.Module==id).Select(x => x).ToList();
                List<SelectListItem> selectItems = new List<SelectListItem>();

                foreach (var item in items)
                {
                    selectItems.Add(new SelectListItem()
                    {
                        Value = item.Value,
                        Text = item.Text
                    });
                }
                return Json(selectItems, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult LoadActions(string id)
        {
            using (KDMDB db = new KDMDB())
            {
                var items = db.tbl_actions.Where(x => x.Controller == id).Select(x => x).ToList();
                List<SelectListItem> selectItems = new List<SelectListItem>();

                foreach (var item in items)
                {
                    selectItems.Add(new SelectListItem()
                    {
                        Value = item.Value,
                        Text = item.Text
                    });
                }
                return Json(selectItems, JsonRequestBehavior.AllowGet);
            }
        }
        
    }
}
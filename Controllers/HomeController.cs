using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MapCharts.DAL;
using MapCharts.Utilities;

namespace MapCharts.Controllers
{

    public class HomeController : Controller
    {
        BasicUtilities utilities = new BasicUtilities();
        mapDAL mapDAL = new mapDAL();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult mapPulsating()
        {
            return View();
        }
        [HttpPost]
        public JsonResult OutletList()
        {
            try
            {
                string _Msg;
                DataTable dt_OutletList = mapDAL.GetOutletData();

                if (dt_OutletList.Rows.Count > 0)
                {
                    _Msg = "DONE";
                    List<Dictionary<string, object>> _OutletList = utilities.GetTableRows(dt_OutletList);
                    return Json(_OutletList);
                }
                else
                {
                    _Msg = "ERROR";
                    return Json(_Msg);
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);

            }
        }


    }
}
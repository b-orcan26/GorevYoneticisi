using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GorevYoneticisi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GorevYoneticisi.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepository<Plan> planRepository;
        public HomeController(IRepository<Plan> planRepository)
        {
            this.planRepository = planRepository;
        }

        public ActionResult Index()
        {      
            return View();
        }

        public JsonResult GetData()
        {
            var data = planRepository.All();
            return Json(data);
        }

        [HttpPost]
        public JsonResult AddData([FromBody] Plan mPlan)
        {
            bool durum = planRepository.Add(mPlan);

            if (durum)
            {
                return Json(new { success = true, responseText = "Ekleme basarili" });
            }
            else
            {
                return Json(new { success = false, responseText = "Ekleme basarisiz" });
            }
        }

        [HttpPost]
        public JsonResult UpdateData([FromBody] Plan mPlan)
        {
            bool durum = planRepository.Update(mPlan);
            if (durum)
            {
                return Json(new { success = true, responseText = "Guncelleme basarili" });
            }
            else
            {
                return Json(new { success = false, responseText = "Guncelleme basarisiz" });
            }
        }

        [HttpPost]
        public JsonResult DeleteData([FromBody] Plan mPlan)
        {
            bool durum = planRepository.Delete(mPlan);

            if (durum)
            {
                return Json(new { success = true, responseText = "Silme basarili" });
            }
            else
            {
                return Json(new { success = false, responseText = "Silme basarisiz" });
            }

        }



    }
}

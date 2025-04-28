using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTDRPladesamling.Repo;

namespace RESTDRPladesamling.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private RecordRepo _recordRepo;

        public RecordController(RecordRepo repo)
        {
            repo = _recordRepo;
        }
        // GET: RecordController2
        public ActionResult GetAll()
        {
            
        }

        //// GET: RecordController2/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: RecordController2/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: RecordController2/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RecordController2/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: RecordController2/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: RecordController2/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RecordController2/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}

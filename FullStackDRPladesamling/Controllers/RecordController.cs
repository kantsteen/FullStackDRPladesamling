using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RESTDRPladesamling.Model;
using RESTDRPladesamling.Repo;
using System.Reflection.Metadata.Ecma335;

namespace RESTDRPladesamling.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private RecordRepo _recordRepo;

        public RecordController(RecordRepo repo)
        {
            _recordRepo = repo;
        }
        // GET: RecordController2

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        [HttpGet]
        public ActionResult GetAll()
        {
            IEnumerable<Record?> result = _recordRepo.GetAll();

            if (result.Any())
            {
                return Ok(result);
            }
            else
            {
                return NoContent();

            }

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

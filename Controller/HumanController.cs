using Human_Body.Interfaces;
using Human_Body.Model;
using Human_Body.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Human_Body
{
    public class HumanController : Controller
    {
        private readonly IHumanBodyRepository repository;

        public HumanController(IHumanBodyRepository _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {


            return View();
        }


        public IActionResult GetOrganInfo(string OrganName)
        {

            var organ =  repository.GetTheOrganInfo(OrganName);
            ViewBag.OrganName =organ.Name ;
            ViewBag.Desc=organ.Description ;


            return View(nameof(Index));
        }



    }
}

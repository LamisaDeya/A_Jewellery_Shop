using JwelleryShop.DAL;
using JwelleryShop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JwelleryShop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public GenericUnitOfWork _unitOfWork= new GenericUnitOfWork();
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Categories() 
        {
            List<category> allcategories = _unitOfWork.GetRepositoryInstance<category>().GetAllRecordsIQueryable().Where(i=> i.isDelete==false).ToList();
            return View(allcategories);
        }
    }
}
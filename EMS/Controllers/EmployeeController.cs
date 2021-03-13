using AutoMapper;
using EMS.BLL.DTO;
using EMS.BLL.Services;
using EMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace EMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;


        public EmployeeController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            var result = _employeeService.GetAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Update(EmployeeViewModal employeeViewModal)
        {
            var empDTO = _mapper.Map<EmployeeDTO>(employeeViewModal);

            if(employeeViewModal.EmployeeId == 0)
            {
                _employeeService.Create(empDTO);
            }
            else
            {
                _employeeService.Update(empDTO);
            }

            return RedirectToAction("Index");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using yeniproje.Models;
using System.Data;
using System.Data.SqlClient;

namespace yeniproje.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();
        string msg;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            EmpClass emp = new EmpClass();
            emp.flag = "get";
            DataSet ds = dbop.Empget(emp,out msg);
            List<EmpClass> list = new List<EmpClass>();
            if (ds.Tables.Count>0)
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                list.Add(new EmpClass
                {
                    id=Convert.ToInt32(dr["id"]),
                    Kadi=dr["Kadi"].ToString(),
                    Adsoyad=dr["AdSoyad"].ToString(),
                    Tel=dr["Tel"].ToString(),
                    Adres=dr["Adres"].ToString(),
                    Acik=dr["Acik"].ToString(),
                    ekle=Convert.ToInt32(dr["ekle"]),
                    cikar=Convert.ToInt32(dr["cikar"]), 
                    Bakiye=Convert.ToInt32(dr["Bakiye"])

            });
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind] EmpClass emp )
        {
           try
            {
                emp.flag = "insert";
                dbop.Empdml(emp, out msg);
                TempData["msg"] = msg;
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            EmpClass emp = new EmpClass();
            emp.id = id;
            emp.flag = "getid";
            DataSet ds = dbop.Empget(emp, out msg); 
            foreach (DataRow dr in ds.Tables[0].Rows)
            {

                emp.id = Convert.ToInt32(dr["id"]);
                emp.Kadi = dr["Kadi"].ToString();
                emp.Adsoyad = dr["AdSoyad"].ToString();
                emp.Tel = dr["Tel"].ToString();
                emp.Adres = dr["Adres"].ToString();
                emp.Acik = dr["Acik"].ToString();
                emp.ekle = Convert.ToInt32(dr["ekle"]);
                emp.cikar = Convert.ToInt32(dr["cikar"]); 
                emp.Bakiye = Convert.ToInt32(dr["Bakiye"]);
            }
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(int id, [Bind] EmpClass emp)
        {
            try
            {
                emp.id = id;
                emp.flag = "update";
                dbop.Empdml(emp, out msg);
                TempData["msg"] = msg;
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                EmpClass emp = new EmpClass();
                emp.flag = "delete";
                emp.id = id;
                dbop.Empdml(emp, out msg);
                TempData["msg"] = msg;
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Bakiye(int id)
        {
            EmpClass emp = new EmpClass();
            emp.id = id;
            emp.flag = "getid";
            DataSet ds = dbop.Empget(emp, out msg);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                emp.id = Convert.ToInt32(dr["id"]);
                emp.Kadi = dr["Kadi"].ToString();
                emp.Adsoyad = dr["AdSoyad"].ToString();
                emp.Tel = dr["Tel"].ToString();
                emp.Adres = dr["Adres"].ToString();
                emp.Acik = dr["Acik"].ToString();
                emp.ekle = Convert.ToInt32(dr["ekle"]);
                emp.cikar = Convert.ToInt32(dr["cikar"]);



            }
            return View(emp);
        }
        [HttpPost]
        public IActionResult Bakiye(int id, [Bind] EmpClass emp)
        {
            try
            {
                emp.id = id;
                emp.flag = "update";
                dbop.Empdml(emp, out msg);
                TempData["msg"] = msg;
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }

            return RedirectToAction("Index");
        }

      
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

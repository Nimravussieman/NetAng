using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using NetAng.Models;
using NetAng.Models.SupportingModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetAng.Controllers
{
    [ApiController]
    [Route("public")]

    public class PublicController : Controller
    {
        private AuthDbContext db;
        public PublicController(AuthDbContext authDbContext) {
            this.db = authDbContext;
        }
        [HttpGet("contactCount")]
        public int ContactCount()
        { 
            int a = this.db.Contacts.Count(c=>c.ContactFieldsPermissions.AddressesIsPublic);
            return a;
        }

        [HttpGet("contactPaginations")]
        //public async Task<List<Contact>> ContactPaginationsAsync(string searchString,int? pageNumber, int pageSize)
        public async Task<Object> ContactPaginationsAsync(string searchString, int? pageNumber, int pageSize)
        {
            var cont = this.db.Contacts.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
                cont.Where(c => c.Name.Name.Contains(searchString)
                               //   || s.FirstMidName.Contains(searchString)
                               );
            var ct = new List<Contact>() { 
                new Contact() { Name = new UserName(){LastName ="a" }, Addresses=new List<Address>(){ new Address() { Value = "Some Address", AddressType = new AddressType() { Name = "Some Type", Id = 1 } } } }, new Contact() { Name = new UserName(){LastName ="ah" } },new Contact() { Name = new UserName(){LastName ="ahj" } },new Contact() { Name = new UserName(){LastName ="adxfht" } },new Contact() { Name = new UserName(){LastName ="aefga" } },new Contact() { Name = new UserName(){LastName ="wsegsdva" } },new Contact() { Name = new UserName(){LastName ="agfba" } },new Contact() { Name = new UserName(){LastName ="aghjvtuk" } },new Contact() { Name = new UserName(){LastName ="rdjkgjhma" } },new Contact() { Name = new UserName(){LastName ="atdyk" } },new Contact() { Name = new UserName(){LastName ="tdyka" } },new Contact() { Name = new UserName(){LastName ="fguy,ka" } },new Contact() { Name = new UserName(){LastName ="yula" } },new Contact() { Name = new UserName(){LastName ="yiula" } },new Contact() { Name = new UserName(){LastName ="ayuk" } },new Contact() { Name = new UserName(){LastName ="hvu,a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="a" } },new Contact() { Name = new UserName(){LastName ="afcgjghmn" } },new Contact() { Name = new UserName(){LastName ="afjmgyuk" } },new Contact() { Name = new UserName(){LastName ="fgjha" } }
            };
            return await PaginatedList<Contact>.CreateAsync(ct.AsQueryable(), pageNumber ?? 1, pageSize);

            //return await PaginatedList<Contact>.CreateAsync(cont.AsNoTracking(), pageNumber ?? 1, pageSize);

            //return await cont.AsNoTracking().ToListAsync();
        }
        [HttpGet("companyPaginations")]
        //public async Task<List<Contact>> ContactPaginationsAsync(string searchString,int? pageNumber, int pageSize)
        public async Task<Object> CompanyPaginationsAsync(string searchString, int? pageNumber, int pageSize)
        {
            var comp = this.db.Companies.AsQueryable();
            if (!String.IsNullOrEmpty(searchString))
                comp.Where(c => c.Name.Contains(searchString)
                               //   || s.FirstMidName.Contains(searchString)
                               );
            var ct = new List<Company>() {
                new Company() { Name = "a" , Addresses=new List<Address>(){ new Address() { Value = "Some Address", AddressType = new AddressType() { Name = "Some Type", Id = 1 } } } }, new Company() { Name  ="ah"  },new Company() { Name = "ahj" },new Company() { Name ="ayuk"  },new Company() { Name = "hvu,a"  },new Company() { Name = "afcgjghmn" },new Company() { Name ="afjmgyuk"  },new Company() { Name = "fgjha" }
            };
            return await PaginatedList<Company>.CreateAsync(ct.AsQueryable(), pageNumber ?? 1, pageSize);

            //return await PaginatedList<Contact>.CreateAsync(cont.AsNoTracking(), pageNumber ?? 1, pageSize);

            //return await cont.AsNoTracking().ToListAsync();
        }



        // GET: PublicController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PublicController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PublicController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublicController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PublicController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PublicController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PublicController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

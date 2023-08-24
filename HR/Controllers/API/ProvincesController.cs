//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using Web_Application.Models;

//namespace Web_Application.Controllers.API
//{
//    //[RoutePrefix("api/hr-provinces")]
//    public class ProvincesController : ApiController
//    {
        
//        private readonly ApplicationDbContext connx;

//        public ProvincesController() 
//        {
//            connx = new ApplicationDbContext();
//        }

//        protected override void Dispose(bool disposing)
//        {
//            connx.Dispose();
//        }

//        //GET /api/Province/
//        [HttpGet]
//        //[Route("get-data")]
//        public IHttpActionResult GetData() 
//        {
//            var datas = connx.Provinces.ToList(); 
//            if (datas == null)
//            {
//                return NotFound();
//            }
//            return Ok(datas);
//        }
//    }
//}

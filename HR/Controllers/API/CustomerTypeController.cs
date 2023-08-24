
//﻿using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Net.Mime;
//using System.Web.Configuration;
//using System.Web.Http;
//using System.Web.UI.WebControls;
//using Web_Application.Models;

//namespace Web_Application.Controllers.API
//{
//    public class CustomerTypeController : ApiController
//    {
//        private readonly ApplicationDbContext _context;

//        public CustomerTypeController()
//        {
//            _context = new ApplicationDbContext();   
//        }

//        protected override void Dispose(bool disposing)
//        {
//            _context.Dispose();
//        }

//        //GET /api/CustomerType/
//        [HttpGet]
//        public IHttpActionResult GetCustomers()
//        {
//            var customers = _context.CustomerTypes.ToList();
//            return Ok(customers);
//        }

//        //GET /api/CustomerType/1
//        [HttpGet]
//        public IHttpActionResult GetCustomer(int id)
//        {
//            var customer = _context.CustomerTypes.SingleOrDefault(c => c.Id == id);
//            if (customer == null) { return NotFound(); }

//            return Ok(customer);
//        }

//        // POST /api/CustomerType
//        [HttpPost]
//        public IHttpActionResult CreateCustomerType(CustomerType customerType)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();
//            var isExist = _context.CustomerTypes.SingleOrDefault(c => c.Name == customerType.Name);
//            if (isExist != null)
//                return BadRequest();

//            _context.CustomerTypes.Add(customerType);

//            _context.SaveChanges();

//            return Created(new Uri(Request.RequestUri + "/" + customerType.Id), customerType);
//        }

//        //Update /api/CustomerType/{id}
//        [HttpPut]
//        public IHttpActionResult UpdateCustomerType(int id, CustomerType customerType)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();
//            var isExist = _context.CustomerTypes.SingleOrDefault(c => c.Name == customerType.Name && c.Id != customerType.Id);
//            if (isExist != null)
//                return BadRequest();

//            var customerTypeInDb = _context.CustomerTypes.SingleOrDefault(c => c.Id == id);

//            _context.CustomerTypes.AddOrUpdate(customerType);

//            _context.SaveChanges();

//            return Ok(customerType);
//        }

//        // Delete /api/CustomerType/{id}
//        [HttpDelete]
//        public IHttpActionResult DeleteCustomerType(int id)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest();
//            var CusInDb = _context.CustomerTypes.SingleOrDefault(c => c.Id == id);
//            if (CusInDb == null)
//                return BadRequest();

//            _context.CustomerTypes.Remove(CusInDb);
//            _context.SaveChanges();
//            return Ok(CusInDb);
//        }
//    }
//}


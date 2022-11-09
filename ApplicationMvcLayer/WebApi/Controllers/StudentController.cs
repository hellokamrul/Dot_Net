﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLC;
using BLC.DTO;

namespace WebApi.Controllers
{
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/student/all")]
        public HttpResponseMessage GetAll()
        {
            var data = StudentService.Get();

            return Request.CreateResponse(HttpStatusCode.OK, data);


        }
    }
}

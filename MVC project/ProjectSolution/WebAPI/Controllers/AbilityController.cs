using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AplicationService.DTOs;
using AplicationService.Implementations;
using WebAPI.Messages;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/ability")]
    public class AbilityController : BaseController
    {
        private readonly AbilityManagementService _servise = null;

        public AbilityController()
        {
            _servise = new AbilityManagementService();    
        }
       

        //localhost:(number)/api/ability
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Json(_servise.Get());   //връща всички 'способности'
        }

        //localhost:(number)/api/ability/1
        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            return Json(_servise.GetById(id));   //връща всички 'способности'
        }
        
        [Route("")]
        [HttpPost]
        public IHttpActionResult Save(AbilityDTO abilityDTO)
        {
            ResponseMessage response = new ResponseMessage();

            if(_servise.Save(abilityDTO))
            {
                response.Code = 201;
                response.Body ="Ability has been saved!" ;
            }
            else
            {
                response.Code = 200;
                response.Body = "Ability has not been saved!";
            }
            return Json(response);
        }

        [Route("")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            ResponseMessage response = new ResponseMessage();

            if (_servise.Delete(id))
            {
                response.Code = 200;
                response.Body = "Ability has been deleted!";
            }
            else
            {
                response.Code = 200;
                response.Body = "Ability has not been deleted!";
            }
            return Json(response);
        }

    }
}

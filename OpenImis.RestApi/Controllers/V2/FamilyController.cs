﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenImis.ModulesV2;
using OpenImis.ModulesV2.InsureeModule.Models;
using OpenImis.ModulesV2.InsureeModule.Models.EnrollFamilyModels;
using OpenImis.RestApi.Security;

namespace OpenImis.RestApi.Controllers.V2
{
    [ApiVersion("2")]
    [Authorize]
    [Route("api/family/")]
    [ApiController]
    public class FamilyController : Controller
    {
        private readonly IImisModules _imisModules;

        public FamilyController(IImisModules imisModules)
        {
            _imisModules = imisModules;
        }

        //[HasRights(Rights.FamilyAdd)]
        [HttpGet]
        [Route("{chfid}")]
        public IActionResult GetByCHFID(string chfid)
        {
            FamilyModel familyModel;

            try
            {
                Guid userUUID = Guid.Parse(HttpContext.User.Claims.Where(w => w.Type == "UserUUID").Select(x => x.Value).FirstOrDefault());
                int userId = _imisModules.GetInsureeModule().GetFamilyLogic().GetUserIdByUUID(userUUID);

                familyModel = _imisModules.GetInsureeModule().GetFamilyLogic().GetByCHFID(chfid, userId);
            }
            catch (ValidationException e)
            {
                return BadRequest(new { error = new { message = e.Message, value = e.Value } });
            }

            if (familyModel == null)
            {
                return NotFound();
            }

            return Ok(familyModel);
        }

        //[HasRights(Rights.FamilyAdd)]
        [HttpPost]
        public IActionResult Create([FromBody] EnrollFamilyModel model)
        {
            int response;

            try
            {
                Guid userUUID = Guid.Parse(HttpContext.User.Claims.Where(w => w.Type == "UserUUID").Select(x => x.Value).FirstOrDefault());

                int userId = _imisModules.GetInsureeModule().GetFamilyLogic().GetUserIdByUUID(userUUID);
                int officerId = _imisModules.GetInsureeModule().GetFamilyLogic().GetOfficerIdByUserId(userId);

                response = _imisModules.GetInsureeModule().GetFamilyLogic().Create(model, userId, officerId);
            }
            catch (ValidationException e)
            {
                return BadRequest(new { error = new { message = e.Message, value = e.Value } });
            }

            return Ok(response);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImisRestApi.Data;
using ImisRestApi.Models;
using ImisRestApi.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ImisRestApi.Controllers
{
    [Produces("application/json")]
    public class ClaimsController : Controller
    {
        private ImisClaims imisClaims;

        public ClaimsController(IConfiguration configuration)
        {
            imisClaims = new ImisClaims(configuration);
        }

        
        [HttpPost]
        [Route("api/GetDiagnosesServicesItems")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(void), StatusCodes.Status401Unauthorized)]
        public IActionResult GetDiagnosesServicesItems([FromBody]DsiInputModel model)
        {
            if (!ModelState.IsValid)
            {
                var error = ModelState.Values.FirstOrDefault().Errors.FirstOrDefault().ErrorMessage;
                return BadRequest(new { error_occured = true, error_message = error });
            }

            try
            {
                var response = imisClaims.GetDsi(model);
                return Json(response);
            }
            catch (Exception e)
            {
                return BadRequest(new { error_occured = true, error_message = e.Message });
            }
            
        }

        [Authorize(Roles = "ClaimAdd")]
        [HttpPost]
        [Route("api/GetPaymentLists")]
        [ProducesResponseType(typeof(void), 200)]
        [ProducesResponseType(typeof(void), StatusCodes.Status401Unauthorized)]
        public IActionResult GetPaymentLists([FromBody]PaymentListsInputModel model)
        {
            if (!ModelState.IsValid)
            {
                var error = ModelState.Values.FirstOrDefault().Errors.FirstOrDefault().ErrorMessage;
                return BadRequest(new { error_occured = true, error_message = error });
            }

            try
            {
               var response = imisClaims.GetPaymentLists(model);
            return Json(response);
            }
            catch (Exception e)
            {
                return BadRequest(new { error_occured = true, error_message = e.Message });
            }
            
        }

        [HttpGet]
        [Route("api/Claims/GetClaimAdmins")]
        public IActionResult ValidateClaimAdmin()
        {

            try
            {

                var data = imisClaims.GetClaimAdministrators();
                return Ok(new { error_occured = false, claim_admins = data });

            }
            catch (Exception e)
            {
                return BadRequest(new { error_occured = true, error_message = e.Message });
            }
     
        }

        [HttpGet]
        [Route("api/Claims/Controls")]
        public IActionResult GetControls()
        {

            try
            {

                var data = imisClaims.GetControls();

                return Ok(new { error_occured = false, controls = data });

            }
            catch (Exception e)
            {
                return BadRequest(new { error_occured = true, error_message = e.Message });

            }

        }
    }
}
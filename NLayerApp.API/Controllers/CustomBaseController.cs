﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayerApp.Core.DTOs;

namespace NLayerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response == null)
            {
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            }
            return  new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}

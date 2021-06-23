using Hotel.Rates.Core;
using Hotel.Rates.Core.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Rates.Api.Controllers
{

    public class BaseApiController : ControllerBase
    {
        public IActionResult GetResult<T>(ServiceResult<T> result)
        {
            return result.ResponseCode switch
            {
                ResponseCode.Ok => Ok(result.Result),
                ResponseCode.BadRequest => BadRequest(result.Error),
                ResponseCode.NotFound => NotFound(result.Error),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using StaffView.ObjectResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Controllers
{
    public abstract class BaseApiController : ControllerBase
    {
        public ServerErrorObjectResult ServerError(object value)
        {
            return new ServerErrorObjectResult(value);
        }
    }
}

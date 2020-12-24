using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FcmbToken.Dto;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Token;
using Token.CheckToken;

namespace FcmbToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
       
        private IVerifyToken _verifyToken;

        public TokenController(IVerifyToken verifyToken)
        {
            _verifyToken = verifyToken;
        }
        
        [HttpGet]
        public IActionResult TokenGenerator()
        {


       
            return Ok(_verifyToken.Verify());

          
           
           
          

        }
    }
}

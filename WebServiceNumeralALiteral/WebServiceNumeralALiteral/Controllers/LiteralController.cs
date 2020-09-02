﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServiceNumeralALiteral.Helpers;

namespace WebServiceNumeralALiteral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiteralController : ControllerBase
    {
        [HttpGet]
        public string literal(int numero)
        {
            string cadena = Conversores.NumeroALetras(numero);
            return cadena;
        }
        [HttpPost]
        public string literal1([FromHeader] int numero)
        {
            string cadena = Conversores.NumeroALetras(numero);
            return cadena;
        }
    }
}

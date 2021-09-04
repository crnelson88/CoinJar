using CoinJar.Api.Model;
using CoinJar.Entities;
using CoinJar.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CoinJar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinJarController : ControllerBase
    {
        private readonly ILogger<CoinJarController> _logger;
        private readonly ICoinJar _coinJar;

        public CoinJarController(ILogger<CoinJarController> logger,
            ICoinJar coinJar)
        {
            _logger = logger;
            _coinJar = coinJar;
        }

        [HttpGet("GetTotalAmount")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(GetTotalAmountResponse))]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetTotalAmount()
        {
            decimal totalAmount = _coinJar.GetTotalAmount();

            return Ok(new GetTotalAmountResponse { TotalAmount = totalAmount });
        }

        [HttpPost("AddCoin")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> AddCoin([FromQuery]AddCoinRequest addCoinRequest)
        {
            IActionResult response = null;

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Coin coin = new Coin
            {
                Amount = addCoinRequest.Amount,
                Volume = addCoinRequest.VolumeInFluidOunces
            };

            _coinJar.AddCoin(coin);

            return Ok();
        }

        [HttpPost("Reset")]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> Reset()
        {
            _coinJar.Reset();

            return Ok();
        }
    }
}

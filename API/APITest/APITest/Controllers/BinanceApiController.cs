using APITest.HubConfig;
using APITest.Models;
using APITest.Services;
using APITest.TimerFeatures;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Net;

namespace APITest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BinanceApiController : ControllerBase
    {
        private IHubContext<BinanceHub> _hub;
        public BinanceApiController(IHubContext<BinanceHub> hub)
        {
            _hub = hub;
        }
        /// <summary>
        /// Tìm kiếm
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(CoinsModelRequest request)
        {
            try
            {
                var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferdata", BinanceServices.GetData(request)));
                return Ok(new { Message = "Kết nối thành công" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = "Kết nối thất bại" });
            }
        }
    }
}

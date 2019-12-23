﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MijnSauna.Backend.Api.Common;
using MijnSauna.Backend.Logic.Interfaces;
using MijnSauna.Common.DataTransferObjects.Sessions;

namespace MijnSauna.Backend.Api.Controllers
{
    [Route("sauna/sessions")]
    [ApiController]
    public class SessionsController : ApiController<ISessionLogic>
    {
        public SessionsController(ISessionLogic sessionLogic) : base(sessionLogic) { }

        [HttpGet("active")]
        public Task<IActionResult> GetActiveSession()
        {
            return Execute(l => l.GetActiveSession());
        }

        [HttpGet]
        public async Task<IActionResult> GetPastSessions()
        {
            await Task.Delay(1);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSession(Guid id)
        {
            await Task.Delay(1);
            return Ok();
        }

        [HttpPost]
        public Task<IActionResult> CreateSession([FromBody] CreateSessionRequest request)
        {
            return Execute(l => l.CreateSession(request));
        }

        [HttpPut("{id}/cancel")]
        public async Task<IActionResult> CancelSession(Guid id)
        {
            await Task.Delay(1);
            return Ok();
        }
    }
}
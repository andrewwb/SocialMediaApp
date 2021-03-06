﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.IO;
using System.Net;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SocialMediaApp.Controllers
{
    [Route("api/[controller]")]
    public class GuideboxController : Controller {
        private HttpClient _client;
        public GuideboxController(HttpClient client) {
            _client = client;
        }
        // GET: api/values
        [HttpGet]
        public async Task<string> Get() {
            var response = await _client.GetAsync("http://api-public.guidebox.com/v2/movies?api_key=6f0450a9b9ec9a2ae2dc406d2bf2478f5ee53d4c");
            return response.Content.ReadAsStringAsync().Result;

        }
    }
}

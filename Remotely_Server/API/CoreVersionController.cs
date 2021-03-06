﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;

namespace Remotely_Server.API
{
    [Route("api/[controller]")]
    public class CoreVersionController : Controller
    {
        public CoreVersionController(IHostingEnvironment hostingEnv)
        {
            this.HostingEnv = hostingEnv;
        }

        public IHostingEnvironment HostingEnv { get; }

        // GET: api/<controller>
        [HttpGet()]
        public string Get()
        {
            var filePath = Path.Combine(HostingEnv.ContentRootPath, "CurrentVersion.txt");
            if (!System.IO.File.Exists(filePath))
            {
                return "0.0.0.0";
            }
            return System.IO.File.ReadAllText(filePath).Trim();
        }
    }
}

﻿using Glimpse.Web;
using System;
using System.Threading.Tasks;

namespace Glimpse.Server.Infrastructure
{
    public class CorsRequestRuntime : IRequestRuntime
    {
        public async Task Begin(IHttpContext newContext)
        {
            newContext.Response.SetHeader("Access-Control-Allow-Origin", "*");
        }

        public async Task End(IHttpContext newContext)
        {
        }
    }
}
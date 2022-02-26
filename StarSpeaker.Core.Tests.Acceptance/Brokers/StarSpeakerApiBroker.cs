// -----------------------------------------------------------------------------------------------
// Copyright (C) Fiqri Ismail 
// Created just for fun for learning purposes of "The Standard" 
// The Standard: https://github.com/hassanhabib/The-Standard
// -----------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using StarSpeaker.Core.Api;

namespace StarSpeaker.Core.Tests.Acceptance.Brokers
{
    public partial class StarSpeakerApiBroker
    {
        private readonly WebApplicationFactory<Startup> _webApplicationFactory;
        private readonly HttpClient _httpClient;
        private readonly IRESTFulApiFactoryClient _apiFactoryClient;


        public StarSpeakerApiBroker()
        {
            _webApplicationFactory = new WebApplicationFactory<Startup>();
            _httpClient = _webApplicationFactory.CreateClient();
            _apiFactoryClient = new RESTFulApiFactoryClient(_httpClient);
        }
    }
}

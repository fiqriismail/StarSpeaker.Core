// -----------------------------------------------------------------------------------------------
// Copyright (C) Fiqri Ismail 
// Created just for fun for learning purposes of "The Standard" 
// The Standard: https://github.com/hassanhabib/The-Standard
// -----------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace StarSpeaker.Core.Tests.Acceptance.Brokers
{
    public partial class StarSpeakerApiBroker
    {
        private const string HomeRelativeUrl = "api/home";

        public async ValueTask<string> GetHomeMessageAsync() =>
            await _apiFactoryClient.GetContentStringAsync(HomeRelativeUrl);
    }
}

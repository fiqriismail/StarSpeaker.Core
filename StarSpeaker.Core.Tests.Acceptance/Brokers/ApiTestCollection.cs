// -----------------------------------------------------------------------------------------------
// Copyright (C) Fiqri Ismail 
// Created just for fun for learning purposes of "The Standard" 
// The Standard: https://github.com/hassanhabib/The-Standard
// -----------------------------------------------------------------------------------------------

using Xunit;

namespace StarSpeaker.Core.Tests.Acceptance.Brokers
{
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection: ICollectionFixture<StarSpeakerApiBroker>
    {
    }
}

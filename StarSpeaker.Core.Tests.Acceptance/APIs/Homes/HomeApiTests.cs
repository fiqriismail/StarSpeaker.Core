using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using StarSpeaker.Core.Tests.Acceptance.Brokers;
using Xunit;

namespace StarSpeaker.Core.Tests.Acceptance.APIs.Homes
{
    [Collection(nameof(ApiTestCollection))]
    public class HomeApiTests
    {
        private readonly StarSpeakerApiBroker _starSpeakerApiBroker;

        public HomeApiTests(StarSpeakerApiBroker starSpeakerApiBroker) =>
            _starSpeakerApiBroker = starSpeakerApiBroker;

        [Fact]
        public async Task ShouldReturnHomeMessageAsync()
        {
            // given
            string expectedMessage =
                "Talk is cheap. Show me the code. ~ Linus Torvalds";

            // when 
            string actualMessage = await _starSpeakerApiBroker.GetHomeMessageAsync();

            // then
            actualMessage.Should().BeEquivalentTo(expectedMessage);
        }
    }
}

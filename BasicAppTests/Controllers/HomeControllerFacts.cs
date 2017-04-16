using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using BasicApp.Controllers;

namespace BasicAppTests
{

    public class HomeControllerFacts
    {
        [Fact]
        public void About_ReturnsAViewResult_WithAMessage()
        {
            // Instantiate
            var controller = new HomeController();

            // Call
            var aboutResult = controller.About();

            //Verify Message Exists
            aboutResult.Should().BeOfType<ViewResult>()
                .Which.ViewData.Should().ContainKey("Message");
        }

        [Fact]
        public void HomeControllerFailingTest(){
            Add(2,3).Should().Be(5);
        }

        int Add(int x, int y){
            return x + y;
        }
    }
}

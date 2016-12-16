using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using BasicApp;
using System.Threading.Tasks;
using System.IO;
using System;

namespace ProgramTests
{

    public class HomeControllerTest
    {

        private readonly TestServer _server;
        private readonly HttpClient _client;

        public HomeControllerTest()
        {

            Console.WriteLine(Directory.GetCurrentDirectory());
            _server = new TestServer(
                new WebHostBuilder().
                    UseContentRoot(Directory.GetCurrentDirectory()).
                    UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [Fact]
        public async Task ReturnHelloWorld()
        {
            var response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            //responseString.Should().Contain("Hello World!");
        }

        //   [Fact]
        //   public void PassingTest(){
        //     //Assert.Equal(4, Add(2,2));
        //     Add(2,2).Should().Be(4);
        //   }

        //   [Fact]
        //   public void FailingTest(){
        //     Add(2,3).Should().Be(4);
        //   }

        //   int Add(int x, int y){
        //     return x + y;
        //   }
    }
}

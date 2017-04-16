using System;
using Xunit;
using FluentAssertions;

namespace BasicAppTests
{
    public class UnitTest1 {

      [Fact]
      public void PassingTest(){
        //Assert.Equal(4, Add(2,2));
        Add(2,2).Should().Be(4);
      }

      [Fact]
      public void FailingTest(){
        Add(2,3).Should().Be(5);
      }

      [Fact]
      public void NewTest(){
        Add(3,3).Should().Be(6);
      }

      int Add(int x, int y){
        return x + y;
      }
  }
}

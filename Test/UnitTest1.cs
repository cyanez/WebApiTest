using System;
using Xunit;

using WebApi;

namespace Test {
  public class UnitTest1 {
    [Fact]
    public void SayHello() {
      Person person = new Person();
      person.Name = "Christian";

      var returnedValue = person.SayHello();

      Assert.Equal("Hello: Christian", returnedValue);
      
    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi {
  public class Person {

    private string name;
    public string Name {
      get => name;
      set => name = value;
    }

    public string SayHello() {
      return $"Hello: {Name}";
    }

  }
}

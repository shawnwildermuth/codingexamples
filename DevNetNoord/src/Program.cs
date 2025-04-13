using System;

//#nullable enable
public static class Program
{
  public static void Main(string[] args)
  {
    Console.Clear();
    Console.WriteLine("Nullable Reference Types");
    Console.WriteLine();

    int? x = 0;
    string? y = "";

    User<string> user = new() { Name = "shawn" };

    x = null;
    y = null;

    ShowValue(x);
    ShowValue(y?.Length);

    var user = new User<string?>()
    {
      Name = 1
    };


  }

  static void ShowValue(object? value)
  {
    Console.WriteLine(string.Concat("Value: ", value ?? "null"));
  }
}


class User<T> where T : notnull 
{

  //public User(string name) => Name = name;



  public int Id { get; set; }
  public required T Name { get; set; }

  public string GetLength()
  {

    //ArgumentNullException.ThrowIfNullOrWhiteSpace(name);
    return Name.ToString() ?? "";
  }
}
//#nullable disable
string[] a = {"1", "2", "3"};
string[] b = {"4", "5", "6"};

a = b;
a[0] = Console.ReadLine();

Console.WriteLine($"{a[0]} {b[0]}");
Console.WriteLine($"{a[1]} {b[1]}");
Console.WriteLine($"{a[2]} {b[2]}");
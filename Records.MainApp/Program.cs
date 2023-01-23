// See https://aka.ms/new-console-template for more information
using Records.MyCommonClassLibrary;

Utility.WriteTitle("Records demonstration and comparison:");

//Value semantics
int i = 4;
int j = i;
//Change j
j = 6;
//Print i, should be 4
Console.WriteLine(i);

string s1 = "Nikos";
string s2 = s1;
//Change s2
s2 = "Margarita";
//Print s1, should be Nikos, due to string immutability
Console.WriteLine(s1);

//Reference semantics with classes
Department d1 = new Department
{
Id = 11,
Name = "Dep 11"
};
Department d2 = d1;
//Change d2
d2.Name = "Dep 1111";
//Print d1.Name, should be Dep 1111 because of the same reference
Console.WriteLine(d1.Name);
//Value-based equality is misleading, because comparison is done on reference level
Console.WriteLine(d1 == d2); //true, although .Name is different
Console.WriteLine(d1.Equals(d2)); //true, although .Name is different

//Reference semantics with records. Records are value types.
Employee e1 = new Employee
{
Id = 1,
Name = "Nikos",
Dob = new DateOnly(1967, 01, 26)
};
Employee e2 = e1;
//Change e2
e2 = e1 with { Name = "Margarita" };
//Print e1, should be 'Nikos' because of record Immutability
Console.WriteLine(e1);
//Built-in support for value-based equality. Comparison is done on value-of-property level
Console.WriteLine(e1 == e2); //false because .Name is different. This is much more close to human thinking!
Console.WriteLine(e1.Equals(e2)); //false because .Name is different. This is much more close to human thinking!

//Extra demos of record
//Using Deconstruct
if (e2 is Employee(var id, var name, var dob) && id > 0 && name != "" && dob != null)
{
    var (ide, namee, dobe) = e2;
    Console.WriteLine($"{namee} {dobe} with id {ide}");
    Console.WriteLine(e2);
}

//Using the more compact way of defining record
Project prj1 = new Project(1, "PRJ1", DateTime.Now, null);
Project prj12 = prj1;
Console.WriteLine(prj12);

//From a class library
Point point1 = new Point(1, 2);
Point point2 = point1 with { X = 3 };
Console.WriteLine(point2);







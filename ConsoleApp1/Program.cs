// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
Console.ReadLine();

int a = 5;
double b = 1.25;
string name = "Matija";
long c = 22L;
bool IsThisTrue = false;
char d = 'a';
var o = 5;
// initializer is required
var averages = new[] { 3.0, 3.34, 4.0, 2.0, 1.8 };

// INTERPOLATED CONSTANTS
    string Name = "George";
    int Age = 44;
    string GeorgeStat = $"{Name} is {Age} years old.";

// implicit cast
    int IntValue = 10;
    long LongValue;
    LongValue = IntValue;

// explicit cast
    long LongValue2 = 10;
    int IntValue2;
    IntValue2 = (int)LongValue2;

// boxing unboxing
    int ForObject = 5;
    Object SomeObject = ForObject;
    ForObject = (int)SomeObject;

// + means concatenate.
    string Name2 = "Randy";
    Console.WriteLine("His name is " + name);

// Stringbuilder
    StringBuilder builder = new StringBuilder("012");
    builder.Append("34");
    builder.Append("56");
    Console.WriteLine(builder.ToString());

// Verbatim String Literal
Console.WriteLine(@"   c:\source\repos   
      (""this is where your code goes"")");

// switch  
string SomeValue = "T";
    switch (SomeValue)
    {
	    case "T":
		    Console.WriteLine("Wow T");
		    break;
        case "P":
        case "O":
        case "Z":
            Console.WriteLine("Wow ZPO");
            break;
        default:
            Console.WriteLine("Number?");
            break;
    }

    static string Quantity(int burgers) => burgers switch
    {
        <= 2 => "too few",
        > 10 => "too many",
        _ => "an acceptable number of",
    };

// if/else statement
    if (IsThisTrue)
    {
        Console.WriteLine("This is true");
    }
    else if (!IsThisTrue)
    {
        Console.WriteLine("This is false");
    }
    else
    {
        Console.WriteLine("Who knows?");
    }

// do/while loop
    while (true)
    {
        Console.WriteLine("Infinity loop");
        break;
    }

    do
    {
        Console.WriteLine("Infinity loop");
        break;
    } while (true);

// for loop
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine(i);
    }

// foreach loop 
// range of array inside []
    int[] NewArray = {1, 2, 3};
    foreach (var item in NewArray[0..2])
    {
        Console.WriteLine(item);
    }

// collections
    List<string> aaaa = new List<string>();
    LinkedList<string> list = new LinkedList<string>();
    // no duplicates
    HashSet<string> bbbb = new HashSet<string>();
    Queue<string> queue = new Queue<string>();
    Stack<string> stack = new Stack<string>();
    Dictionary<string, string> dict = new Dictionary<string, string>();

    //  Add(key, value).
    dict.Add("C#", "cool");
    dict.Add("C++", "like writing Sanskrit poetry in Morse code");
    dict.Add("VB", "a simple but wordy language");

    Console.WriteLine("Contains C# " + dict.ContainsKey("C#"));


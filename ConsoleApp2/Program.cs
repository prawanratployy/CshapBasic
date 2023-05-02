// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Console.Write("Name : ");
string name = Console.ReadLine();

Console.Write("Input weight (kg) : ");
int weight = int.Parse(Console.ReadLine());

Console.Write("Input height (cm) : ");
int height = int.Parse(Console.ReadLine());

double
*/


/*
Console.Write("Your Position : ");
string position = Console.ReadLine();

Console.Write("Your Salary : ");
float salary = float.Parse(Console.ReadLine());


if (position == "Assistant Developer")
{
    float A = salary + ((salary * 5) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {A}");
}
else if (position == "IT Support")
{
    float I = salary + ((salary * 7) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {I}");
}
else if (position == "Senior Developer")
{
    float S = salary + ((salary * 10) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {S}");
}
else if (position == "Administrator")
{
    float Ad = salary + ((salary *8 ) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {Ad}");
}
else
{
    float e = salary + ((salary * 3) / 100);
    Console.WriteLine($"Your Salary will be increased to =  {e}");
}
*/


/*Console.Write("Number of student? : ");
float numstu = float.Parse(Console.ReadLine());
Console.WriteLine("------------");


for  (int i = 0; i < numstu; i++)
{
    Console.Write("Student Id : ");
    string stuid = Console.ReadLine();

    Console.Write("Score : ");
    float score = float.Parse(Console.ReadLine());

    Console.WriteLine($"Student Id {stuid} score is {score}");
    
    Console.WriteLine("------------ ");

    if (j == 'n')
    {  
        break;
        Console.Write("Exit? : ");
        string e = Console.ReadLine();
      
        
    }
    
    //Console.Write("Exit? : ");
    //string e = Console.ReadLine();
}*/

public class vehicle
{
    
    public string name
    {
        get { return name; }
        set { name = value; }
    }

    public double speed
    { 
        get { return speed; } 
        set {  speed = value; }
    }

}

public class bicycle : vehicle
{
    public bicycle(string name, double speed)
    {
        Namecar = name;
        Speed = speed;
    }
}
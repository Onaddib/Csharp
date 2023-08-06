

Console.WriteLine("Enter your x axis");
string numX = Console.ReadLine();
Console.WriteLine("Enter your y axis");
string numY = Console.ReadLine();


int x = Convert.ToInt32(numX);
int y = Convert.ToInt32(numY);


Quadrant(x, y);




static   int Quadrant(int x, int y)
{
    int answer = 0;

    if (x > 0 && y > 0)
    {
        answer = 1;
        Console.WriteLine($"Coordinated you entered in the {answer}. zone");
    }
    else if (x < 0 && y > 0)
    {
        answer = 2;
        Console.WriteLine($"Coordinated you entered in the {answer}. zone");
    }
    else if (x < 0 && y < 0)
    {
        answer = 3;
        Console.WriteLine($"Coordinated you entered in the {answer}. zone");
    }
    else
    {
        answer = 4;
        Console.WriteLine($"Coordinated you entered in the {answer}. zone");
    }


  return answer;
        }



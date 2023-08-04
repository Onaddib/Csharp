

    Console.WriteLine("Please enter your word");
    string w = Console.ReadLine();
    //Console.WriteLine($"Your word: {w}");


    char[] reverseArray = w.ToCharArray();
    Array.Reverse(reverseArray);
    string reverseWord = new string(reverseArray);



    if (w == reverseWord)
    {
        Console.WriteLine($"Word {w} is a palindrome word");
    }
    else
    {
        Console.WriteLine($"Word ${w} is not polindrome");
    }



    //Console.WriteLine(reverseWord.GetType());











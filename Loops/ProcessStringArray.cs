using System;

public class ProcessStringArray
{
    public static void Run()
    {
        string[] myStrings = new string[2]
               {
            "I like pizza. I like roast chicken. I like salad",
            "I like all three of the menu choices"
               };

        int periodLocation = 0;

        for (int i = 0; i < myStrings.Length; i++)
        {
            do
            {
                myStrings[i] = myStrings[i].TrimStart();
                periodLocation = myStrings[i].IndexOf('.');
                if (periodLocation != -1)
                {
                    Console.WriteLine(myStrings[i].Substring(0, periodLocation));
                    myStrings[i] = myStrings[i].Substring(periodLocation + 1);
                }
                else
                {
                    Console.WriteLine(myStrings[i]);
                    break;
                }
            }
            while (periodLocation != -1);

        }
    }
}
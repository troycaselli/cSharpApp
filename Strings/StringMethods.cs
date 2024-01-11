using System;

public class StringMethods
{
    public static void Run()
    {
        // ===== INDEXOF(), LASTINDEXOF(), INDEXOFANY() =====================================

        // string message = "Find what is (inside the parentheses)";

        // int openingPosition = message.IndexOf('(') + 1;
        // int closingPosition = message.IndexOf(')');

        // Console.WriteLine(openingPosition);
        // Console.WriteLine(closingPosition);

        // int length = closingPosition - openingPosition;
        // Console.WriteLine(message.Substring(openingPosition, length));


        // string message2 = "What is the value <span>between the tags</span>?";

        // const string openSpan = "<span>";
        // const string closeSpan = "</span>";

        // int openingPosition2 = message2.IndexOf(openSpan);
        // int closingPosition2 = message2.IndexOf(closeSpan);

        // openingPosition2 += openSpan.Length;
        // int length2 = closingPosition2 - openingPosition2;
        // Console.WriteLine(message2.Substring(openingPosition2, length2));


        // string message3 = "(What if) I am (only interested) in the last (set of parentheses)?";
        // int openingPosition3 = message3.LastIndexOf('(');
        // openingPosition3 += 1;
        // int closingPosition3 = message3.LastIndexOf(')');
        // int length3 = closingPosition3 - openingPosition3;
        // Console.WriteLine(message3.Substring(openingPosition3, length3));


        // string message4 = "(What if) there is (more than) one (set of parentheses)?";
        // while (true)
        // {
        //     int openingPosition4 = message4.IndexOf('(');
        //     if (openingPosition4 == -1) break;

        //     openingPosition4 += 1;
        //     int closingPosition4 = message4.IndexOf(')');
        //     int length4 = closingPosition4 - openingPosition4;
        //     Console.WriteLine(message4.Substring(openingPosition4, length4));

        //     // Note the overload of the Substring to return only the remaining 
        //     // unprocessed message4:
        //     message4 = message4.Substring(closingPosition4 + 1);

        // string message5 = "Help (find) the {opening symbols}";
        // Console.WriteLine($"Searching THIS Message: {message5}");
        // char[] openSymbols = { '[', '{', '(' };
        // int startPosition5 = 6;
        // int openingPosition5 = message5.IndexOfAny(openSymbols);
        // Console.WriteLine($"Found WITHOUT using startPosition: {message5.Substring(openingPosition5)}");

        // openingPosition5 = message5.IndexOfAny(openSymbols, startPosition5);
        // Console.WriteLine($"Found WITH using startPosition {startPosition5}: {message5.Substring(openingPosition5)}");


        // string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

        // // The IndexOfAny() helper method requires a char array of characters. 
        // // You want to look for:

        // char[] openSymbols = { '[', '{', '(' };

        // // You'll use a slightly different technique for iterating through 
        // // the characters in the string. This time, use the closing 
        // // position of the previous iteration as the starting index for the 
        // //next open symbol. So, you need to initialize the closingPosition 
        // // variable to zero:

        // int closingPosition = 0;

        // while (true)
        // {
        //     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

        //     if (openingPosition == -1) break;

        //     string currentSymbol = message.Substring(openingPosition, 1);

        //     // Now  find the matching closing symbol
        //     char matchingSymbol = ' ';

        //     switch (currentSymbol)
        //     {
        //         case "[":
        //             matchingSymbol = ']';
        //             break;
        //         case "{":
        //             matchingSymbol = '}';
        //             break;
        //         case "(":
        //             matchingSymbol = ')';
        //             break;
        //     }

        //     // To find the closingPosition, use an overload of the IndexOf method to specify 
        //     // that the search for the matchingSymbol should start at the openingPosition in the string. 

        //     openingPosition += 1;
        //     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

        //     // Finally, use the techniques you've already learned to display the sub-string:

        //     int length = closingPosition - openingPosition;
        //     Console.WriteLine(message.Substring(openingPosition, length));
        // }


        // ===== REMOVE(), REPLACE() ================================================

        // string data = "12345John Smith          5000  3  ";
        // string updatedData = data.Remove(5, 20);
        // Console.WriteLine(updatedData);

        // string message6 = "This--is--ex-amp-le--da-ta";
        // message6 = message6.Replace("--", " ");
        // message6 = message6.Replace("-", "");
        // Console.WriteLine(message6);
    }
}
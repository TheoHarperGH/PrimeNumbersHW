//Prime Numbers

using System.Transactions;

Console.WriteLine("The first few prime numbers are : ");

for (int Current = 0; Current < 50; Current++)
{
    CheckCurrent = 2;
    bool Prime = true;
    while (CheckCurrent * CheckCurrent <= Current)
    {
        if (Current % CheckCurrent == 0)
        {
            Prime = false;
        }
        CheckCurrent++;
    }
    if (Prime & Current > 1)
    {
        Console.WriteLine(Current);
    }
}

//Used boolean instead of string "Yes" and "No" from pseudocode
//also imo better variable names compared to "Count1" and "Count2"
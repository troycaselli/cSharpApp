using System;

public class Currency
{
    double usd = 23.73;
    int vnd;

    public Currency()
    {
        vnd = UsdToVnd(usd);
    }

    public void DisplayCurrency()
    {
        Console.WriteLine($"${usd} USD = ${vnd} VND");
        Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
    }

    int UsdToVnd(double usd)
    {
        return (int)(usd * 23500);
    }

    double VndToUsd(int vnd)
    {
        return vnd / (double)23500;
    }
}
namespace CalcApp.Models;

/// <summary>
/// Class Calculator
/// </summary>
public static class Calc
{
    /// <summary>
    /// simple calculating
    /// </summary>
    /// <param name="first">first operand</param>
    /// <param name="second">second operand</param>
    /// <param name="operation">operation: '+', '-', '*', '/'</param>
    /// <returns>result of operation</returns>
    /// <exception cref="DivideByZeroException">if second operand == 0 and operation == '/'</exception>
    /// <exception cref="ArgumentException">Unknown operation</exception>
    public static double Calculation(double first, double second, char operation)
    {
        return operation switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => second != 0 ? first / second : throw new DivideByZeroException(),
            _ => throw new ArgumentException($"Unexpected value operator: {operation}"),
        };
    }

    /// <summary>
    /// get square root
    /// </summary>
    /// <param name="number">input</param>
    /// <returns>square root</returns>
    /// <exception cref="ArgumentException">if number less than 0</exception>
    public static double SquareRootExtraction(double number)
    {
        if(number < 0) throw new ArgumentException($"number can't less zero");
        return Math.Sqrt(number);
    }
     
    /// <summary>
    /// calculate purchase with discount
    /// </summary>
    /// <param name="purchase">amount purchase</param>
    /// <param name="discount">amount discount</param>
    /// <returns>result with discount</returns>
    /// <exception cref="ArgumentException">purchase must be more than 0, and discount in range from 0 to 1</exception>
    public static double CalculatingDiscount(double purchase, double discount)
    {
        if (purchase < 0) 
            throw new ArgumentException("purchase can't be less 0");
        if (discount < 0 || discount > 1) 
            throw new ArgumentException("discount can't be less than 0 or more than 1");
        return purchase - purchase * discount;
    }
}


namespace HWmain;

public class SimpleCheckService
{
    /// <summary>
    /// HW 3.1. Нужно покрыть тестами метод на 100%
    /// Метод проверяет, является ли целое число записанное в
    /// переменную n, чётным(true) либо нечётным(false).
    /// </summary>
    /// 
    public bool IsOddNumber(int input) => input % 2 == 1;


    /// <summary>
    /// HW 3.2. Нужно написать метод, который проверяет,
    /// попадает ли переданное число в интервал(25;100) и
    /// возвращает true, если попадает и false - если нет,
    /// покрыть тестами метод на 100%
    /// </summary>
    public bool IsNumberInRange(int input) => input >= 25 && input <= 100;


}

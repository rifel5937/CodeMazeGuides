﻿namespace ActionAndFuncDelegates
{
    public static class CallbackController
    {
        public static IEnumerable<string> CountDown(int count, Func<int, string> func)
        {
            for (var i = 0; i < count; i++)
            {
                yield return func(count - i);
            }
        }

        public static string CalculateMinusOne(int number)
        {
            return number.ToString();
        }
    }
}
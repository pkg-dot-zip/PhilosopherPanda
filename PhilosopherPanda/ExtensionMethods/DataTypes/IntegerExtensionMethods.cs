using System.Globalization;

namespace PhilosopherPanda.ExtensionMethods.DataTypes;

public static class IntegerExtensionMethods
{
    /// <summary>
    /// Checks if a number is even, and returns true if it is.
    /// </summary>
    /// <param name="value">Number to check.</param>
    /// <returns>True if value is even.</returns>
    public static bool IsEven(this int value) => value % 2 == 0;

    /// <summary>
    /// Checks if a number is odd, and returns true if it is.
    /// </summary>
    /// <param name="value">Number to check.</param>
    /// <returns>True if value is odd.</returns>
    public static bool IsOdd(this int value) => value % 2 != 0;

    /// <summary>
    /// Performs a given action a given amount of times.
    /// </summary>
    /// <param name="amount">The amount of times to perform the action.</param>
    /// <param name="action">The action to perform a given amount of times.</param>
    public static void DoFor(this int amount, Action action)
    {
        for (var i = 0; i < amount; i++) action();
    }

    /// <summary>
    /// Performs a given action a given amount of times.
    /// Will pass the iteration as a parameter to the action.
    /// </summary>
    /// <param name="amount">The amount of times to perform the action.</param>
    /// <param name="action">The action to perform a given amount of times. Takes in the iteration amount.</param>
    public static void DoFor(this int amount, Action<int> action)
    {
        for (var i = 0; i < amount; i++) action(i);
    }
}
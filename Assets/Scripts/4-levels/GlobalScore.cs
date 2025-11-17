using UnityEngine;

public static class GlobalScore
{
    public static int Value = 0;
    public static void Add(int amount)
    {
        Value += amount;
    }
}

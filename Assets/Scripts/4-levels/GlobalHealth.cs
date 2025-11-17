using UnityEngine;

public class GlobalHealth
{
    public static int Current = 3;
    public static int Max = 3;

    public static void ResetHealth()
    {
        Current = Max;
    }
}

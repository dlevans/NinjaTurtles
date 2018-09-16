using System;

public class RatProperties
{
    public bool hasShell = false;
    public bool isGreen = false;
    public string species = "Rat";
}

public class SplinterProperties : RatProperties
{
    public bool isLeader = true;
    public string weapon = "Ninja AF";
    public string color = "Brown";
    public bool canFight = true;
}
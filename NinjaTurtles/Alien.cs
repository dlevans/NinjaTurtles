using System;

public class AlienProperties
{
    public bool hasShell = false;
    public bool isGreen = false;
    public string species = "Alien";
}

public class KrangProperties : AlienProperties
{
    public bool isLeader = true;
    public string weapon = "Lots of them";
    public string color = "Pink";
    public bool canFight = true;
}
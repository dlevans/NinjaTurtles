using System;

public class TurtleProperties
{
    public bool hasShell = true;
    public bool isGreen = true;
    public bool canFight = true;
    public string species = "Turtle";
}

public class LeonardoProperties : TurtleProperties
{
    public bool isLeader = true;
    public string weapon = "Swords";
    public string color = "Blue";
}

public class MichelangeloProperties : TurtleProperties
{
    public bool isLeader = false;
    public string weapon = "Nunchucks";
    public string color = "Orange";
}

public class RaphaelProperties : TurtleProperties
{
    public bool isLeader = false;
    public string weapon = "Sai";
    public string color = "Red";
}

public class DonatelloProperties : TurtleProperties
{
    public bool isLeader = false;
    public string weapon = "Staff";
    public string color = "Purple";
}
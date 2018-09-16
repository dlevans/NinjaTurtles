using System;

public class HumanProperties
{
    public bool hasShell = false;
    public bool isGreen = false;    
    public string species = "Human";
}

public class AprilProperties : HumanProperties
{
    public bool isLeader = false;
    public string weapon = "Microphone";
    public string color = "Yellow";
    public bool canFight = false;
}

public class ShredderProperties : HumanProperties
{
    public bool isLeader = true;
    public string weapon = "Arm things";
    public string color = "Silver / Gray";
    public bool canFight = true;
}
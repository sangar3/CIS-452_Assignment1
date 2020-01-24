using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ForceSensitive
{
    public abstract void LightsaberAttack();

}

public class LightSide: ForceSensitive
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom vroom ");
    }
    void ForcePowers()
    {
        Debug.Log("The force is with you");
    }
}





public class DarkSide : ForceSensitive
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom ");
    }
    public void ForceChoke()
    {
        Debug.Log("*Choke");
    }
    public void ForceLighting()
    {
        Debug.Log("*Lighting");
    }
}

public class Neutralside : ForceSensitive 
{
    public double forceStrength;
    public string Race;
    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom vroom ");
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ForceSensitive
{
    public abstract void LightsaberAttack();

}

public class LightSide: ForceSensitive, CanForcePowers, ChooseLightsabercolor
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom vroom ");
    }
    public void ForcePowers()
    {
        Debug.Log("The force is with you");
    }
    public void Lightsabercolor()
    {
        Debug.Log("choose wisley");
    }
}





public class DarkSide : ForceSensitive, CanForcePowers, ChooseLightsabercolor
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom ");
    }
    public void ForcePowers()
    {
        Debug.Log("The force is with you");
    }
    public void Lightsabercolor()
    {
        Debug.Log("choose wisley");
    }
}

public class Neutralside : ForceSensitive, CanForcePowers, ChooseLightsabercolor
{
    public double forceStrength;
    public string Race;
    public override void LightsaberAttack()
    {
        Debug.Log("vroom vroom vroom ");
    }
   public  void ForcePowers()
    {
        Debug.Log("The force is with you");
    }
    public void Lightsabercolor()
    {
        Debug.Log("choose wisley");
    }
}
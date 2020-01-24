using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ForceSensitive
{
    public abstract void LightsaberAttack();

}

public class LightSide: ForceSensitive, CanForceHeal, CanForcePush
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom");
    }
    public void ForcePush()
    {
        Debug.Log("*Push");
    }
    public void ForceHeal()
    {
        Debug.Log("*heal");
    }
}





public class DarkSide : ForceSensitive, CanForceChoke, CanForceLighting
{
    public double forceStrength;
    public string Race;

    public override void LightsaberAttack()
    {
        Debug.Log("vroom");
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
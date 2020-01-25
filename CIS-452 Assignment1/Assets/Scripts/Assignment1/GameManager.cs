/*
		 * (Santiago Garcia II)
		 * (GameManager)
		 * (Assignment 1)
		 * (Creates instances when the buttons 1 or 2 are pressed)
	*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public ForceSensitive Jediplayer;
    public ForceSensitive Sithplayer;
    public ForceSensitive Neutralplayer;



    public List<ForceSensitive> playerslist = new List<ForceSensitive>();

    public List<CanForcePowers> ForcePowersinterface = new List<CanForcePowers>();

    public List<ChooseLightsabercolor> ChooseLightsabercolorinterface = new List<ChooseLightsabercolor>();

    

    void Start()
    {

        Jediplayer = new LightSide();

        Jediplayer.LightsaberAttack();
        Sithplayer = new DarkSide();
        Sithplayer.LightsaberAttack();
        Neutralplayer = new Neutralside();
        Neutralplayer.LightsaberAttack();

        for (int i = 0; i < 2; i++)
        {
            playerslist.Add(new LightSide());
            playerslist.Add(new DarkSide());
            playerslist.Add(new Neutralside());
        }

        for (int i = 0; i < 1; i++)
        {
            
            ForcePowersinterface.Add(new Neutralside());
            ChooseLightsabercolorinterface.Add(new Neutralside());

        }



    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (ForceSensitive player in playerslist)
            {
                player.LightsaberAttack();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           foreach(CanForcePowers forcepowers in ForcePowersinterface)
            {
                forcepowers.ForcePowers();
            }
           foreach (ChooseLightsabercolor color in ChooseLightsabercolorinterface)
            {
                color.Lightsabercolor();
            }
        }

    }
}  

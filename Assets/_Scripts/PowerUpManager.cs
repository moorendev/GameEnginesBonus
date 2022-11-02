using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public GameObject powerUp;  // Powerup object goes here
    public GameObject player;   // This is the player instance
    bool isPoweredUp = false;   // Determines whether player destroys barrels on collision

    private static PowerUpManager instance = null;

    public static PowerUpManager GetInstance()  // Singleton GameObject creation things
    {
        if (instance == null)   // Creating a new instance if one doesn't currently exist
        {
            GameObject obj = new GameObject("PowerUpManager");
            instance = obj.AddComponent<PowerUpManager>();
            DontDestroyOnLoad(instance);    // Making sure the instance doesn't disappear if we change scenes
        }
        return instance;        // Either way we're returning an instance
    }

    private void Awake()
    {
        instance = this;                // Set the singleton instance = this
        DontDestroyOnLoad(instance);    // Redundant check to keep the instance from being destroyed on load
    }

    public void PowerUpToggle()
    {
        isPoweredUp = !isPoweredUp;     //Changes the boolean value for whether the player is powered up
    }

    public bool GetPoweredUp()
    {
        return isPoweredUp;
    }
}

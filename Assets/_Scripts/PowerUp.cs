using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpManager powerUpManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            powerUpManager.PowerUpToggle();
            Destroy(gameObject);
        }
    }
}

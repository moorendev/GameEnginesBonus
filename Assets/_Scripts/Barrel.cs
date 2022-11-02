using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrel : MonoBehaviour
{
    public Transform spawnpoint;
    public Vector3 spawnspeed;
    private void OnEnable()
    {
        transform.GetComponent<Rigidbody>().WakeUp();
    }

    private void OnDisable()
    {
        transform.GetComponent<Rigidbody>().Sleep();
    }

    private void OnCollisionEnter(Collision other)
    {
        // Destroy(gameObject);

        if (other.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (other.collider.tag == "Respawn")
        {
            transform.GetComponent<Rigidbody>().position = spawnpoint.position;
            transform.GetComponent<Rigidbody>().velocity = spawnspeed;
        }
    }
}
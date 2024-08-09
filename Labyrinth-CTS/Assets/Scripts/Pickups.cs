using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public ParticleSystem Pickup;

    void Start()
    {
        Pickup.Stop();
    }
    private void OnTriggerEnter(Collider Sphere)
    {
        if (Sphere.CompareTag("Sphere"))
        {
            Destroy(Sphere.gameObject);

            Pickup.Play();
        }
    }
}

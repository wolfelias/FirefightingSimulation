using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEmission : MonoBehaviour
{
    // public GameObject smallFire;
    public bool isBurning = true;
    private ParticleSystem _ps;

    // Start is called before the first frame update
    void Start()
    {
        _ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurning)
        {
            StartFire();
        }
        else
        {
            StopFire();
        }
    }

    private void StartFire()
    {
        var emissionModule = _ps.emission;
        emissionModule.enabled = true;
    }

    private void StopFire()
    {
        var emissionModule = _ps.emission;
        emissionModule.enabled = false;
    }
}
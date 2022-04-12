using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public bool largeFlamesBurning = false;
    public bool mediumFlamesBurning = false;
    public bool tinyFlameBurning = false;

    private GameObject _largeFlames;
    private GameObject _fireEmbers;
    private GameObject _mediumFlames;
    private GameObject _tinyFlames;
    private GameObject _smoke;

    private int position_x;
    private int position_z;


    // Start is called before the first frame update
    void Start()
    {
        int numberOfChildren = transform.childCount;
        foreach (Transform g in transform.GetComponentsInChildren<Transform>())
        {
            var child = g.gameObject;
            switch (child.name)
            {
                case "LargeFlames":
                    _largeFlames = child;
                    break;

                case "FireEmbers":
                    _fireEmbers = child;
                    break;

                case "MediumFlames":
                    _mediumFlames = child;
                    break;

                case "TinyFlames":
                    _tinyFlames = child;
                    break;

                case "SmokeEffect":
                    _smoke = child;
                    break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        _largeFlames.GetComponent<ToggleEmission>().isBurning = largeFlamesBurning;
        _fireEmbers.GetComponent<ToggleEmission>().isBurning = largeFlamesBurning;
        _mediumFlames.GetComponent<ToggleEmission>().isBurning = mediumFlamesBurning;
        _tinyFlames.GetComponent<ToggleEmission>().isBurning = tinyFlameBurning;
        bool smokeIsPresent = largeFlamesBurning || mediumFlamesBurning || tinyFlameBurning;
        _smoke.GetComponent<ToggleEmission>().isBurning = smokeIsPresent;
    }
}
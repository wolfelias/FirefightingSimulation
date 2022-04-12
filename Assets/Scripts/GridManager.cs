using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float x_start, z_start;
    public int columnLength, rowLength;
    public float x_space, z_space;
    public GameObject firePrefab;

    private int position_x;
    private int position_z;

    private List<GameObject> fires = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < columnLength; i++)
        {
            for (int j = 0; j < rowLength; j++)
            {
                Debug.Log("i * j: " + (i * j));
                Debug.Log("i +  j: " + (i + j));
                GameObject fire = Instantiate(firePrefab,
                    new Vector3(x_start + (x_space * (i % columnLength)), 0,
                        z_start + (-z_space * (j % columnLength))),
                    Quaternion.identity);
                fire.transform.parent = GameObject.Find("FireParent").transform;
                position_x = j;
                position_z = i;
                fires.Add(fire);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
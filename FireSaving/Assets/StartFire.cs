using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFire : MonoBehaviour
{
    public GameObject objectToInstantiate; // Assign your GameObject in the Inspector
    public int numberOfObjects = 5; // Number of objects to instantiate
    public float xRange = 10.0f; // Range for X-axis
    public float yRange = 5.0f;  // Range for Y-axis
    public float zRange = 10.0f; // Range for Z-axis

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            GenerateRandomObject();
        }
    }

    void GenerateRandomObject()
    {
        // Generate a random position
        Vector3 randomPosition = new Vector3(Random.Range(-xRange, xRange), Random.Range(-yRange, yRange), Random.Range(-zRange, zRange));

        // Instantiate the GameObject at the random position
        Instantiate(objectToInstantiate, randomPosition, Quaternion.identity);
    }
}

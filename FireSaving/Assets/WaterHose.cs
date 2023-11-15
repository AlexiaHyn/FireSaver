using Leap.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class WaterHose : MonoBehaviour
{
    public GameObject prefab;
    public float spawnSpeed = 15;
    Stopwatch timer = new Stopwatch();

    public GameObject anchor;
    public HandPoseDetector hoseDetector;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Water()
    {
        GameObject spawnedBall = Instantiate(prefab, anchor.transform.position, Quaternion.identity);
        Rigidbody spawnedBallRB = spawnedBall.GetComponent<Rigidbody>();
        spawnedBallRB.velocity = anchor.transform.forward * spawnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.ElapsedMilliseconds > 25)
        {
            timer.Restart();
            Water();
        }

        bool isHose = (hoseDetector.GetCurrentlyDetectedPose() != null);

        /*
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            timer.Start();
        }
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            timer.Stop();
        }
        */

        if (isHose)
        {
            timer.Start();
        }
        else
        {
            timer.Stop();
        }
    }
}
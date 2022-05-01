using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class MovingSpeedNoise : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxMovingSpd;
    public float minMovingSpd;
    public float acc;
    public PathFollower pf;
    public float movingSpd;
    void Start()
    {
        pf = GetComponent<PathFollower>();
        movingSpd = pf.speed;
    }

    // Update is called once per frame
    void Update()
    {
        movingSpd += acc;
        pf.speed = movingSpd;
        if (movingSpd > maxMovingSpd || movingSpd < minMovingSpd)
        {
            acc = -acc;
        }
    }
}

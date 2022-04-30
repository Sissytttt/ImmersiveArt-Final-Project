using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFliesTrigger : MonoBehaviour
{
    public float fireflyStartTime;
    private float _fireflyStartTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        _fireflyStartTimer = fireflyStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_fireflyStartTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            _fireflyStartTimer -= Time.deltaTime;
        }
    }
    
}

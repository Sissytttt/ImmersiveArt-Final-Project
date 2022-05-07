using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafTornadoTrigger : MonoBehaviour
{
    
    public float leafTornadoStartTime;
    private float _leafTornadoStartTimer;

    public float leafTornadoEndTime;
    private float _leafTornadoEndTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        _leafTornadoStartTimer = leafTornadoStartTime;
        _leafTornadoEndTimer = leafTornadoEndTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_leafTornadoStartTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            _leafTornadoStartTimer -= Time.deltaTime;
        }
        
        if (_leafTornadoEndTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            _leafTornadoEndTimer -= Time.deltaTime;
        }
        
    }
}

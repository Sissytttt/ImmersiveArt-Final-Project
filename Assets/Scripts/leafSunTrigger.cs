using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafSunTrigger : MonoBehaviour
{
    public float leafSunStartTime;
    private float _leafSunStartTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        _leafSunStartTimer = leafSunStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_leafSunStartTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            _leafSunStartTimer -= Time.deltaTime;
        }
    }
}

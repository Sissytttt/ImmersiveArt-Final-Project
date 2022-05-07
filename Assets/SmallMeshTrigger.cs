using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallMeshTrigger : MonoBehaviour
{
    public float meshStartTime;
    private float _meshStartTimer;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
        _meshStartTimer = meshStartTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (_meshStartTimer < 0)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else
        {
            _meshStartTimer -= Time.deltaTime;
        }

    }
}

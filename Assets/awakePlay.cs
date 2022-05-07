using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakePlay : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ps;
    
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

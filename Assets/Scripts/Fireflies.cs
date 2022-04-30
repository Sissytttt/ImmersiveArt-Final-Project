using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fireflies : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ps;

    public float maxEmission;
    public float curEmission;
    
    public float addEmissionTime;
    private float _addEmissionTimer;
    
    public float maxShape;
    public float curShape;
    
    public float addShapeTime;
    private float _addShapeTimer;
    
    public Vector3 topPos;

    private Animator _anim;
    
    void Start()
    {
        _addShapeTimer = addShapeTime;
        _addEmissionTimer = addEmissionTime;
        ps = GetComponent<ParticleSystem>();
        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        // if (ps.emission.rateOverTime < maxEmission)
        // {
        //     ps.emission += 1;
        // }


        if (_addEmissionTimer < 0)
        {
            _addEmissionTimer = addEmissionTime;
            if (curEmission < maxEmission)
            {
                var emission = ps.emission;
                curEmission += 1.0f;
                emission.rateOverTime = curEmission;
            }
        }
        else
        {
            _addEmissionTimer -= Time.deltaTime;
        }
        
        
        if (_addShapeTimer < 0)
        {
            _addShapeTimer = addShapeTime;
            if (curShape < maxShape)
            {
                var shape = ps.shape;
                curShape += 1.0f;
                shape.radius = curShape;
            }
        }
        else
        {
            _addShapeTimer -= Time.deltaTime;
        }
        
    }
}

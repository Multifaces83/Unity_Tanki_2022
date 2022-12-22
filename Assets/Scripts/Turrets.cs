using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turrets : BaseController
{
    private Transform target;
    private Vector3 direction;
    [SerializeField] private float maxRangeAttack = 5f;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Tank").transform;
    }

    // Update is called once per frame
    void Update()
    {
        direction = target.position - transform.position;
        transform.rotation= Quaternion.LookRotation(direction);

        if (DetectEnnemies(maxRangeAttack))
        {
            Fire();
        }
        
    }
}

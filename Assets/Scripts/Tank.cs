using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : BaseController
{
    [SerializeField] private float speed = 0.2f;
    [SerializeField] private float speedRotate = 30f;
    [SerializeField] private float maxRangeAttack = 50f;
    private void Update()
    {
        Move();

        //Fire + recoil
        if(Input.GetMouseButtonDown(0)){
            Fire();            
        }



        RaycastHit hit;
        if (Physics.Raycast(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up, out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);

        }
    }
    
    private void Move()
    {
        //Forward
       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z) ){
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }
        //Back
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        //Rotate Left
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, speedRotate * Time.deltaTime, 0f );
        }
        //Rotate Right
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, -speedRotate * Time.deltaTime, 0f);
        }
    }

}
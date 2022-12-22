using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected int LifePoint = 1;
    [SerializeField] protected float DelayValue = 2f;
    //protected int maxLifePoint;
    //protected int minLifePoint;
    //protected int ammo;
    //protected float fireRate;
    //protected float fireRange;
    //protected float fireSpeed;
    //protected int damage;


    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
    }
    protected bool DetectEnnemies(float maxRange)
    {
        bool detect = false;
        RaycastHit hit;
        if (Physics.Raycast(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up, out hit, maxRange))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);
            detect = true;
            
        }
        return detect;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

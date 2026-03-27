using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    public Transform startPos;
    // Start is called before the first frame update
   
    void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
                GameObject bullet = Instantiate(bulletPrefab,startPos.position,startPos.rotation);
                Destroy(bullet , 1.5f);
        }

    }
}

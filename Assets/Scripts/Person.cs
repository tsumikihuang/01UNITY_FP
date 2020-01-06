using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    private float next_bullet = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > next_bullet)
        {
            next_bullet = Time.time + 0.5f;     //每隔0.5秒才能發射一次子彈
            object obj = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
            GameObject bullet = obj as GameObject;
            Destroy(bullet, 0.3f);
            
        }
    }

}

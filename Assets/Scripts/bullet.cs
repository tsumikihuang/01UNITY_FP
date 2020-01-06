using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bullet : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0, 1, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monstor"))
        {
            Destroy(other.gameObject);
            Score.instance.ChangeScore(10);
        }

    }

}



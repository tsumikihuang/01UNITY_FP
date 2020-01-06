using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public GameObject ray;
    float time = 10;
    public Transform PutBoomPoint;
    public GameObject BoomPrefab;
    public GameObject countdown;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 10)
        {
            countdown.SetActive(false);
            countdown.SetActive(true);
            ray.SetActive(true);
            if (time > 11)
            {
                ray.SetActive(false);
                    time = 0;
                    object obj = Instantiate(BoomPrefab, PutBoomPoint.position, PutBoomPoint.rotation);
                    GameObject boom = obj as GameObject;
                    Destroy(boom, 3);
                    ray.transform.position = new Vector3(ray.transform.position.x, ray.transform.position.y, ray.transform.position.z + 150);
                    PutBoomPoint.position = new Vector3(ray.transform.position.x, PutBoomPoint.position.y, ray.transform.position.z);
                }
        }
    }
}

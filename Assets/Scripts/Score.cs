using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static public Score instance;
    int Score_num = 0;
    public Text Score_text;
    public GameObject gameObject;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void ChangeScore(int changeNum)
    {
        Score_num += changeNum;
    }

    void Update()
    {
        Score_num = (int)(gameObject.transform.position.z * 10);
        Score_text.text = "" + Score_num;       
    }
}

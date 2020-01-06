using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour
{
    static public blood instance;
    int blood_num = 1000;
    public Text blood_text;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void ChangeBlood(int changeNum)
    {
        blood_num += changeNum;
    }

    public void Dead()
    {
        blood_num = 0;
    }
    // Update is called once per frame
    void Update()
    {
        blood_text.text = "" + blood_num;
        if (blood_num <= 0)
        {
            Debug.LogError("Game Over!");
            ChangeScene.instance.GoToGameOver();
        }
    }
}

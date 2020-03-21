using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimeCount;
    public Text countDownText;
    void Start()
    {
        TimeCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount -= Time.deltaTime;
        countDownText.text = "カウントダウン：" + TimeCount.ToString("f0");

        if(TimeCount <= 0){
            countDownText.text = "ゲーム終了";
        }
    }
}

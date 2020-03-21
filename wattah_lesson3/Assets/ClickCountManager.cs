using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickCountManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int clickCount;
    public Text clickCountText;
    public TimeCountManager timeCountManager;
    void Start()
    {
        clickCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeCountManager.TimeCount > 0){
            if (Input.GetMouseButtonUp(0))
            {
                clickCount++;
            }
        }
        clickCountText.text = "クリック数：" + clickCount.ToString();
    }
}

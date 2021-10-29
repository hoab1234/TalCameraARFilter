using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
    float time;

    private void Update()
    {
        if (time < 0.5f)
        {
            GetComponent<RawImage>().color = new Color(1, 1, 1, 1 - time);
        }
        else
        {
            GetComponent<RawImage>().color = new Color(1, 1, 1, time);
            if (time > 1f)
            {
                time = 0;
            }
        }

        time += Time.deltaTime;
    }
}

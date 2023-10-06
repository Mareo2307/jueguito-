using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    [SerializeField] int min, seg;
    [SerializeField] Text time;


    private float remaining;
    private bool ongoing;


    private void Awake()
    {
        remaining =(min * 60) + seg;
        ongoing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (ongoing)
        {
            remaining -= Time.deltaTime;
            if (remaining < 1)
            {
                ongoing = true;
                //Tridimin loses
            }
            int temmin = Mathf.FloorToInt(remaining / 60);
            int temseg = Mathf.FloorToInt(remaining % 60);
            time.text = string.Format("{00:00}:{01:00}", temmin, temseg);
        }
    }
}

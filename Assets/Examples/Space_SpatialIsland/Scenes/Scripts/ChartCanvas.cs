using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChartCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.SetBarValue(0, "before", 0.0f);
        this.SetBarValue(0, "After", 0.0f);

        this.SetBarValue(1, "before", 0.0f);
        this.SetBarValue(1, "After", 0.0f);

        this.SetBarValue(2, "before", 0.0f);
        this.SetBarValue(2, "After", 0.0f);

        this.SetBarValue(3, "before", 0.0f);
        this.SetBarValue(3, "After", 0.0f);
    }

    public void SetBarValue(int snumber, string seriesname, float val)
    {
        var barimage = this.transform.Find("bar" + snumber.ToString() + seriesname).gameObject.GetComponent<Image>();
        var tr = barimage.rectTransform;
        tr.sizeDelta = new Vector2(50, val * 100);
        var localpos = tr.localPosition;
        localpos.y = (int)(-1 * ((500 - val * 100.0f) / 2));
        tr.localPosition = localpos;

        var value  = this.transform.Find("bar" + snumber.ToString() + seriesname+"Val").gameObject.GetComponent<Text>();
        value.text = Math.Round(val,2).ToString();
        
        var tr2 = value.rectTransform;
        var localpos2 = tr2.localPosition;
        localpos.y = (int)(-1 * ((500 - val * 100.0f) / 2) + val * 50 + 10);
        tr2.localPosition = localpos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

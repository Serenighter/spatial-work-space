using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldCanvas : MonoBehaviour
{
    // Start is called before the first frame update

    public Canvas MyCanvas;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void refreshCanvas()
    {
        var canv = MyCanvas.GetComponent<CanvasCalculate>();
        
        canv.ShowChangeValues();
    }

    

    public int? GetInputValue()
    {
        InputField obj = this.gameObject.GetComponent<InputField>();
        string str = obj.text;
        int val = 0;
        if (int.TryParse(str,out val))
        {
            if (val >= 0 && val <= 5) return val;
            return val;
        }              
        return null;
    }

    public void Increment()
    {
       InputField obj = this.gameObject.GetComponent<InputField>();
        

        string str = obj.text;
        int val = 0;
        if (int.TryParse(str, out val))
        {
            if (val == 0 || val == 1 || val == 2 || val == 3 || val == 4 || val == 5)
            {
                if (val < 5) val = val + 1;             
            }
            else val = 0;
            obj.text = val.ToString();
        }
        else obj.text = "0";
        refreshCanvas();

    }

    public void Decrement()
    {
        InputField obj = this.gameObject.GetComponent<InputField>();

        string str = obj.text;
        int val = 0;
        if (int.TryParse(str, out val))
        {
            if (val == 0 || val == 1 || val == 2 || val == 3 || val == 4 || val == 5)
            {
                if (val > 0) val = val - 1;
                else
                {
                    obj.text = "";
                    refreshCanvas();
                    return;
                }
                obj.text = val.ToString();
            }         
        }
        else obj.text = "";
        refreshCanvas();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class NewBehaviourScript : MonoBehaviour
{

    int CurrentIndex = 0;
    public int MaxCanvasNumber;
        
    
    public void HideAllCanvases()
    {
        for (int i=0;i<=MaxCanvasNumber;i++)
        {
            this.transform.Find("Canvas" + i.ToString()).gameObject.SetActive(false);
        }
    }
    
    
    public void NextPage()
    {
        if (CurrentIndex < MaxCanvasNumber)
        {
            HideAllCanvases();
            CurrentIndex = CurrentIndex + 1;
            this.transform.Find("Canvas" + CurrentIndex.ToString()).gameObject.SetActive(true);
        }
    }
    
    public void PrevPage()
    {
        if (CurrentIndex > 0)
        {
            HideAllCanvases();
            CurrentIndex = CurrentIndex - 1;
            this.transform.Find("Canvas" + CurrentIndex.ToString()).gameObject.SetActive(true);
        }
    }
    
    
    public void CalculateAvgValues(int start, int final, out float? avgbefore, out float? avgafter, out float? avgchanges)
    {
        if (final <= MaxCanvasNumber)
        {
            float sumbefore = 0.0f;
            int cntbefore = 0;
            float sumafter = 0.0f;
            int cntafter = 0;
            float sumchanges = 0.0f;
            int cntchanges = 0;
            for (int i = start; i <= final; i++)
            {
                var canv = this.transform.Find("Canvas" + i.ToString()).gameObject.GetComponent<CanvasCalculate>();
                
                // calculate all fields before
                if (canv.lifespanbefore != null) { sumbefore += (float)canv.lifespanbefore; cntbefore++; }
                if (canv.servicingbefore != null) { sumbefore += (float)canv.servicingbefore; cntbefore++; }
                if (canv.effectivenessbefore != null) { sumbefore += (float)canv.effectivenessbefore; cntbefore++; }
                if (canv.efficiencybefore != null) { sumbefore += (float)canv.efficiencybefore; cntbefore++; }
                if (canv.fairnessbefore != null) { sumbefore += (float)canv.fairnessbefore; cntbefore++; }

                // calculate all fields after
                if (canv.lifespanafter != null) { sumafter += (float)canv.lifespanafter; cntafter++; }
                if (canv.servicingafter != null) { sumafter += (float)canv.servicingafter; cntafter++; }
                if (canv.effectivenessafter != null) { sumafter += (float)canv.effectivenessafter; cntafter++; }
                if (canv.efficiencyafter != null) { sumafter += (float)canv.efficiencyafter; cntafter++; }
                if (canv.fairnessafter != null) { sumafter += (float)canv.fairnessafter; cntafter++; }

                // calculate all fields change
                if (canv.lifespanchanges != null) { sumchanges += (float)canv.lifespanchanges; cntchanges++; }
                if (canv.servicingchanges != null) { sumchanges += (float)canv.servicingchanges; cntchanges++; }
                if (canv.effectivenesschanges != null) { sumchanges += (float)canv.effectivenesschanges; cntchanges++; }
                if (canv.efficiencychanges != null) { sumchanges += (float)canv.efficiencychanges; cntchanges++; }
                if (canv.fairnesschanges != null) { sumchanges += (float)canv.fairnesschanges; cntchanges++; }
            }

            if (cntbefore > 0) avgbefore = (float)(sumbefore / (float)cntbefore);
            else avgbefore = null;

            if (cntafter > 0) avgafter = (float)(sumafter / (float)cntafter);
            else avgafter = null;

            if (cntchanges > 0) avgchanges = (float)(sumchanges / (float)cntchanges);
            else avgchanges = null;
        }
        else
        {

            avgbefore = null;
            avgafter = null;
            avgchanges = null;
        }
    }

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    public Vector3 rotationAngles = new Vector3(0.0f, 50.0f, 0.0f);
    private void Update()
	{
    		
	}

    
    public void DecrementInputFieldLifespanBefore()
    {
        var obj = GameObject.Find("InputFieldLifespanBefore").GetComponent<InputField>();
        obj.text = "-";
    }

    public void IncrementInputFieldLifespanBefore()
    {
        var obj = GameObject.Find("InputFieldLifespanBefore").GetComponent<InputField>();
        obj.text = "+";
    }

    public void Calculate()
    {
        var obj = GameObject.Find("CanvasReport");
        if (obj != null)
        {
            var rep = obj.GetComponent<ReportCalculate>();
            rep.CalculateReport();
        }


    }
}

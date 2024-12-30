using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasCalculate : MonoBehaviour
{
    // Start is called before the first frame update
    public int? lifespanbefore = null, lifespanafter = null, lifespanchanges = null;
    public int? servicingbefore = null, servicingafter = null, servicingchanges = null;
    public int? effectivenessbefore = null, effectivenessafter = null, effectivenesschanges = null;
    public int? efficiencybefore = null, efficiencyafter = null, efficiencychanges = null;
    public int? fairnessbefore = null, fairnessafter = null, fairnesschanges = null;

    void Start()
    {
        ResetInputFields();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int? checkVal(string str)
    {
        int val = -1;
        if (int.TryParse(str, out val))
        {
            if (val >= 0 && val <= 5) return val;
            else return null;
        }
        return null;
    }


    public void ResetInputFields()
    {
        var obj = this.transform.Find("InputFieldLifespanBefore").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldLifespanAfter").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldServicingBefore").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldServicingAfter").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldEffectivenessBefore").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldEffectivenessAfter").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldEfficiencyBefore").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldEfficiencyAfter").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldFairnessBefore").gameObject.GetComponent<InputField>();
        obj.text = "";
        obj = this.transform.Find("InputFieldFairnessAfter").gameObject.GetComponent<InputField>();
        obj.text = "";
    }

    public void GetFieldsValues()
    {
        var obj = this.transform.Find("InputFieldLifespanBefore").gameObject.GetComponent<InputField>();
        lifespanbefore = checkVal(obj.text);
        obj = this.transform.Find("InputFieldLifespanAfter").gameObject.GetComponent<InputField>();
        lifespanafter = checkVal(obj.text);
        if (lifespanbefore != null && lifespanafter != null) lifespanchanges = lifespanafter - lifespanbefore;
        else lifespanchanges = null;

        obj = this.transform.Find("InputFieldServicingBefore").gameObject.GetComponent<InputField>();
        servicingbefore = checkVal(obj.text);
        obj = this.transform.Find("InputFieldServicingAfter").gameObject.GetComponent<InputField>();
        servicingafter = checkVal(obj.text);
        if (servicingbefore != null && servicingafter != null) servicingchanges = servicingafter - servicingbefore;
        else servicingchanges = null;

        obj = this.transform.Find("InputFieldEffectivenessBefore").gameObject.GetComponent<InputField>();
        effectivenessbefore = checkVal(obj.text);
        obj = this.transform.Find("InputFieldEffectivenessAfter").gameObject.GetComponent<InputField>();
        effectivenessafter = checkVal(obj.text);
        if (effectivenessbefore != null && effectivenessafter != null) effectivenesschanges = effectivenessafter - effectivenessbefore;
        else effectivenesschanges = null;

        obj = this.transform.Find("InputFieldEfficiencyBefore").gameObject.GetComponent<InputField>();
        efficiencybefore = checkVal(obj.text);
        obj = this.transform.Find("InputFieldEfficiencyAfter").gameObject.GetComponent<InputField>();
        efficiencyafter = checkVal(obj.text);
        if (efficiencybefore != null && efficiencyafter != null) efficiencychanges = efficiencyafter - efficiencybefore;
        else efficiencychanges = null;

        obj = this.transform.Find("InputFieldFairnessBefore").gameObject.GetComponent<InputField>();
        fairnessbefore = checkVal(obj.text);
        obj = this.transform.Find("InputFieldFairnessAfter").gameObject.GetComponent<InputField>();
        fairnessafter = checkVal(obj.text);
        if (fairnessbefore != null && fairnessafter != null) fairnesschanges = fairnessafter - fairnessbefore;
        else fairnesschanges = null;

    }

    public void RefreshReport()
    {
        var obj = GameObject.Find("CanvasReport");
        if (obj != null)
        {
            var rep = obj.GetComponent<ReportCalculate>();
            rep.CalculateReport();
        }
        
    }



    public void ShowChangeValues()
    {
        GetFieldsValues();

        
        var obj = this.transform.Find("LifespanChange").gameObject.GetComponent<Text>();
        if (obj != null)
        {
            if (lifespanchanges != null) obj.text = lifespanchanges.ToString();
            else obj.text = "";
        }
        else obj.text = "";

        obj = this.transform.Find("ServicingChange").gameObject.GetComponent<Text>();
        if (obj != null)
        {
            if (servicingchanges != null) obj.text = servicingchanges.ToString();
            else obj.text = "";
        }
        else obj.text = "";

        obj = this.transform.Find("EffectivenessChange").gameObject.GetComponent<Text>();
        if (obj != null)
        {
            if (effectivenesschanges != null) obj.text = effectivenesschanges.ToString();
            else obj.text = "";
        }
        else obj.text = "";

        obj = this.transform.Find("EfficiencyChange").gameObject.GetComponent<Text>();
        if (obj != null)
        {
            if (efficiencychanges != null) obj.text = efficiencychanges.ToString();
            else obj.text = "";
        }
        else obj.text = "";

        obj = this.transform.Find("FairnessChange").gameObject.GetComponent<Text>();
        if (obj != null)
        {
            if (fairnesschanges != null) obj.text = fairnesschanges.ToString();
            else obj.text = "";
        }
        else obj.text = "";

        RefreshReport();
    }

}

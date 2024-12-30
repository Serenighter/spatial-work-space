using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ReportCalculate : MonoBehaviour
{

    public GameObject PeopleHolder;
    public GameObject EnvHolder;
    public GameObject ProspHolder;

    public ChartCanvas PlanetChart;
    public ChartCanvas PeopleChart;
    public ChartCanvas ProspChart;


    public void CalculateReport()
    {
        float? before, after, changes;
        before = null; after = null; changes = null;

        // calculate planet
        var planet = EnvHolder.GetComponent<NewBehaviourScript>();
        planet.CalculateAvgValues(0, 3, out before, out after, out changes);
        if (before != null) { this.transform.Find("P1Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PlanetChart.SetBarValue(0, "before", (float)before); }
        else this.transform.Find("P1Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("P1After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PlanetChart.SetBarValue(0, "After", (float)after); }
        else this.transform.Find("P1After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("P1Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes,2).ToString();
        else this.transform.Find("P1Change").gameObject.GetComponent<Text>().text = "-";

        planet.CalculateAvgValues(4, 6, out before, out after, out changes);
        if (before != null) { this.transform.Find("P2Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PlanetChart.SetBarValue(1, "before", (float)before);}
        else this.transform.Find("P2Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("P2After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PlanetChart.SetBarValue(1, "After", (float)after); }
        else this.transform.Find("P2After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("P2Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("P2Change").gameObject.GetComponent<Text>().text = "-";

        planet.CalculateAvgValues(7, 12, out before, out after, out changes);
        if (before != null) { this.transform.Find("P3Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PlanetChart.SetBarValue(2, "before", (float)before); }
        else this.transform.Find("P3Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("P3After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PlanetChart.SetBarValue(2, "After", (float)after); }
        else this.transform.Find("P3After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("P3Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("P3Change").gameObject.GetComponent<Text>().text = "-";

        planet.CalculateAvgValues(13, 16, out before, out after, out changes);
        if (before != null) { this.transform.Find("P4Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PlanetChart.SetBarValue(3, "before", (float)before); }
        else this.transform.Find("P4Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("P4After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PlanetChart.SetBarValue(3, "After", (float)after); }
        else this.transform.Find("P4After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("P4Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("P4Change").gameObject.GetComponent<Text>().text = "-";

        /// Calculate human
        var human = PeopleHolder.GetComponent<NewBehaviourScript>();
        human.CalculateAvgValues(0, 7, out before, out after, out changes);
        if (before != null) { this.transform.Find("H1Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PeopleChart.SetBarValue(0, "before", (float)before); }
        else this.transform.Find("H1Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("H1After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PeopleChart.SetBarValue(0, "After", (float)after); }
        else this.transform.Find("H1After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("H1Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("H1Change").gameObject.GetComponent<Text>().text = "-";


        human.CalculateAvgValues(8, 13, out before, out after, out changes);
        if (before != null) { this.transform.Find("H2Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PeopleChart.SetBarValue(1, "before", (float)before); }
        else this.transform.Find("H2Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("H2After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PeopleChart.SetBarValue(1, "After", (float)after); }
        else this.transform.Find("H2After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("H2Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("H2Change").gameObject.GetComponent<Text>().text = "-";

        human.CalculateAvgValues(14, 17, out before, out after, out changes);
        if (before != null) { this.transform.Find("H3Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PeopleChart.SetBarValue(2, "before", (float)before); }
        else this.transform.Find("H3Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("H3After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PeopleChart.SetBarValue(2, "After", (float)after); }
        else this.transform.Find("H3After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("H3Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("H3Change").gameObject.GetComponent<Text>().text = "-";


        human.CalculateAvgValues(18, 22, out before, out after, out changes);
        if (before != null) { this.transform.Find("H4Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); PeopleChart.SetBarValue(3, "before", (float)before); }
        else this.transform.Find("H4Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("H4After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); PeopleChart.SetBarValue(3, "After", (float)after); }
        else this.transform.Find("H4After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("H4Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("H4Change").gameObject.GetComponent<Text>().text = "-";

        // Calculate prosperity
        var prosp = ProspHolder.GetComponent<NewBehaviourScript>();

        prosp.CalculateAvgValues(0, 3, out before, out after, out changes);
        if (before != null) { this.transform.Find("D1Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); ProspChart.SetBarValue(0, "before", (float)before); }
        else this.transform.Find("D1Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("D1After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); ProspChart.SetBarValue(0, "After", (float)after); }
        else this.transform.Find("D1After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("D1Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("D1Change").gameObject.GetComponent<Text>().text = "-";
        

        prosp.CalculateAvgValues(4, 5, out before, out after, out changes);
        if (before != null) { this.transform.Find("D2Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); ProspChart.SetBarValue(1, "before", (float)before); }
        else this.transform.Find("D2Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("D2After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); ProspChart.SetBarValue(1, "After", (float)after); }
        else this.transform.Find("D2After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("D2Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("D2Change").gameObject.GetComponent<Text>().text = "-";

        
        prosp.CalculateAvgValues(6, 8, out before, out after, out changes);
        if (before != null) { this.transform.Find("D3Before").gameObject.GetComponent<Text>().text = Math.Round((decimal)before, 2).ToString(); ProspChart.SetBarValue(2, "before", (float)before); }
        else this.transform.Find("D3Before").gameObject.GetComponent<Text>().text = "-";
        if (after != null) { this.transform.Find("D3After").gameObject.GetComponent<Text>().text = Math.Round((decimal)after, 2).ToString(); ProspChart.SetBarValue(2, "After", (float)after); }
        else this.transform.Find("D3After").gameObject.GetComponent<Text>().text = "-";
        if (changes != null) this.transform.Find("D3Change").gameObject.GetComponent<Text>().text = Math.Round((decimal)changes, 2).ToString();
        else this.transform.Find("D3Change").gameObject.GetComponent<Text>().text = "-";

        //Calculate overall 
        float? avgplanet = null, avgpeople = null, avgprosp = null;
        planet.CalculateAvgValues(0, 16, out before, out avgplanet, out changes);
        human.CalculateAvgValues(0, 22, out before, out avgpeople, out changes);
        prosp.CalculateAvgValues(0, 8, out before, out avgprosp, out changes);
        if (avgplanet != null) this.transform.Find("PlanetScore").gameObject.GetComponent<Text>().text = Math.Round((decimal)avgplanet, 2).ToString();
        else this.transform.Find("PlanetScore").gameObject.GetComponent<Text>().text = "-";
        if (avgpeople != null) this.transform.Find("HumanScore").gameObject.GetComponent<Text>().text = Math.Round((decimal)avgpeople, 2).ToString();
        else this.transform.Find("HumanScore").gameObject.GetComponent<Text>().text = "-";
        if (avgprosp != null) this.transform.Find("ProsperityScore").gameObject.GetComponent<Text>().text = Math.Round((decimal)avgprosp, 2).ToString();
        else this.transform.Find("ProsperityScore").gameObject.GetComponent<Text>().text = "-";

        if (avgplanet != null && avgpeople != null && avgprosp != null)
        {
            var projrep = (avgplanet + avgpeople + avgprosp) / 3.0f;
            this.transform.Find("ProjectScore").gameObject.GetComponent<Text>().text = Math.Round((decimal)projrep, 2).ToString();

        }
        else this.transform.Find("ProjectScore").gameObject.GetComponent<Text>().text = "-";


       

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

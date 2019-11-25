using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System;
using Simulation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class DescriptionPanel : MonoBehaviour
{
    [SerializeField] public GameObject SimulatorDriver = null;

    public Text Name;
    public Text Age;
    public Text Weight;
    public Text Height;
    public Text BodyDensity;
    public Text BodyFatFraction;
    public Text LeanBodyMass;
    public Text AlveoliSurfaceArea;
    public Text RightLungRatio;
    public Text SkinSurfaceArea;
    public Text BasalMetabolicRate;
    public Text BloodVolumeBaseline;

    private SimulationData simulationData;
    void Start()
    {
        LoadDataFromJson();
    }

    public void LoadDataFromJson()
    {
        if(SimulatorDriver == null)
        {
            SimulatorDriver = GameObject.FindGameObjectWithTag("SimulatorDriver");
        }
        
        StreamReader reader;
        Debug.Log(SimulatorDriver.GetComponent<SimulatorDriver>().TextAsset.name);
        reader = new StreamReader(Application.dataPath + "/StreamingAssets/" + SimulatorDriver.GetComponent<SimulatorDriver>().TextAsset.name + ".json");
        string json = reader.ReadToEnd();
        reader.Close();

        simulationData = SimulationData.FromJson(json);

        Patient patient = simulationData.Patient;
        Name.text = patient.Name;
        Age.text = patient.Age.ScalarTime.Value + " " + patient.Age.ScalarTime.Unit;
        Weight.text = RoundValue(patient.Weight.ScalarMass.Value).ToString() + " " + patient.Weight.ScalarMass.Unit;
        Height.text = RoundValue(patient.Height.ScalarLength.Value).ToString() + " " + patient.Height.ScalarLength.Unit;
        BodyDensity.text = RoundValue(patient.BodyDensity.ScalarMassPerVolume.Value).ToString() + " " + patient.BodyDensity.ScalarMassPerVolume.Unit;
        BodyFatFraction.text = RoundValue(patient.BodyFatFraction.Scalar0To1.Value).ToString();
        LeanBodyMass.text = RoundValue(patient.LeanBodyMass.ScalarMass.Value).ToString() + " " + patient.LeanBodyMass.ScalarMass.Unit;
        AlveoliSurfaceArea.text = RoundValue(patient.AlveoliSurfaceArea.ScalarArea.Value).ToString() + " " + patient.AlveoliSurfaceArea.ScalarArea.Unit;
        RightLungRatio.text = RoundValue(patient.RightLungRatio.Scalar0To1.Value).ToString();
        SkinSurfaceArea.text = RoundValue(patient.SkinSurfaceArea.ScalarArea.Value).ToString() + " " + patient.SkinSurfaceArea.ScalarArea.Unit;
        BasalMetabolicRate.text = RoundValue(patient.BasalMetabolicRate.ScalarPower.Value).ToString() + " " + patient.BasalMetabolicRate.ScalarPower.Unit;
        BloodVolumeBaseline.text = RoundValue(patient.BloodVolumeBaseline.ScalarVolume.Value).ToString() + " " + patient.BloodVolumeBaseline.ScalarVolume.Unit;


    }

    public static decimal RoundValue(double? x)
    {
        return Math.Round((decimal)x, 2, MidpointRounding.AwayFromZero);
    }
}

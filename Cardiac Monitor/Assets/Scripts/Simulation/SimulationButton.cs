using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using System;
using Simulation;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class SimulationButton : MonoBehaviour
{
    [SerializeField] public GameObject SimulatorDriver = null;
    public SimulationsPanel SimulationsPanel;
    [SerializeField] public TextAsset TextAsset;
    [SerializeField] public GameObject Button;
    [SerializeField] public Text ButtonText;
    private SimulationData simulationData;
    public string Path;
    public string BuildPath;

    private void Start()
    {
#if UNITY_EDITOR
        Path = AssetDatabase.GetAssetPath(TextAsset);
        BuildPath = TextAsset.name;
#endif
    }

    public void LoadDataFromJson()
    {
        StreamReader reader;

        reader = new StreamReader(Application.dataPath + "/StreamingAssets/" + BuildPath + ".json");
#if UNITY_EDITOR
        reader = new StreamReader(Path);
#endif
        Debug.Log(Application.dataPath + "/StreamingAssets/ " + BuildPath + ".json");
        string json = reader.ReadToEnd();
        reader.Close();

        simulationData = SimulationData.FromJson(json);

        Patient patient = simulationData.Patient;
        SimulationsPanel.Name.text = patient.Name;
        SimulationsPanel.Age.text = patient.Age.ScalarTime.Value + " " + patient.Age.ScalarTime.Unit;
        SimulationsPanel.Weight.text = RoundValue(patient.Weight.ScalarMass.Value).ToString() + " " + patient.Weight.ScalarMass.Unit;
        SimulationsPanel.Height.text = RoundValue(patient.Height.ScalarLength.Value).ToString() + " " + patient.Height.ScalarLength.Unit;
        SimulationsPanel.BodyDensity.text = RoundValue(patient.BodyDensity.ScalarMassPerVolume.Value).ToString() + " " + patient.BodyDensity.ScalarMassPerVolume.Unit;
        SimulationsPanel.BodyFatFraction.text = RoundValue(patient.BodyFatFraction.Scalar0To1.Value).ToString();
        SimulationsPanel.LeanBodyMass.text = RoundValue(patient.LeanBodyMass.ScalarMass.Value).ToString() + " " + patient.LeanBodyMass.ScalarMass.Unit;
        SimulationsPanel.AlveoliSurfaceArea.text = RoundValue(patient.AlveoliSurfaceArea.ScalarArea.Value).ToString() + " " + patient.AlveoliSurfaceArea.ScalarArea.Unit;
        SimulationsPanel.RightLungRatio.text = RoundValue(patient.RightLungRatio.Scalar0To1.Value).ToString();
        SimulationsPanel.SkinSurfaceArea.text = RoundValue(patient.SkinSurfaceArea.ScalarArea.Value).ToString() + " " + patient.SkinSurfaceArea.ScalarArea.Unit;
        SimulationsPanel.BasalMetabolicRate.text = RoundValue(patient.BasalMetabolicRate.ScalarPower.Value).ToString() + " " + patient.BasalMetabolicRate.ScalarPower.Unit;
        SimulationsPanel.BloodVolumeBaseline.text = RoundValue(patient.BloodVolumeBaseline.ScalarVolume.Value).ToString() + " " + patient.BloodVolumeBaseline.ScalarVolume.Unit;

        SimulatorDriver = GameObject.FindGameObjectWithTag("SimulatorDriver");
        SimulatorDriver.GetComponent<SimulatorDriver>().TextAsset = TextAsset;
    }

    public static decimal RoundValue(double? x)
    {
        return Math.Round((decimal)x, 2, MidpointRounding.AwayFromZero);
    }
}



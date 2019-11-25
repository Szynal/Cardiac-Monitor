using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class SimulationsPanel : MonoBehaviour
{
    [SerializeField] public List<TextAsset> simulationFiles;
    [SerializeField] private GameObject prototypeItem = null;
    
    public Transform ContentList;

    [Header("Description Panel")]
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

    readonly string[] removeString = { "@0s" };

    private void Awake()
    {
         //CreateSimulationButtons();
    }

    public void CreateSimulationButtons()
    {
        foreach (TextAsset simulationFile in simulationFiles)
        {
            GameObject simulationButton = Instantiate(prototypeItem, ContentList);
            SimulationButton button = simulationButton.GetComponent<SimulationButton>();

            if (button != null)
            {
                button.SimulationsPanel = this;
                button.TextAsset = simulationFile;
                string simulationFileName = simulationFile.name;


                foreach (string substring in removeString)
                {
                    if (simulationFileName.EndsWith(substring))
                    {
                        simulationFileName = simulationFileName.Substring(0, simulationFileName.LastIndexOf(substring));
                        break;
                    }
                }
                simulationButton.name = simulationFileName;
                button.ButtonText.text = Regex.Replace(simulationFileName, "(\\B[A-Z])", " $1");
            }
        }
    }
}



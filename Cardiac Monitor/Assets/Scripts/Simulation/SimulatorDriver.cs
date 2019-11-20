using UnityEngine;
using System.Collections;

public class SimulatorDriver : MonoBehaviour
{
    [SerializeField] public TextAsset TextAsset;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}

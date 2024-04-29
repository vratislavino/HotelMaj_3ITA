using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    [SerializeField]
    private BuildingScriptable buildingData;

    [SerializeField]
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var towerData in buildingData.data)
        {
            // Vytvoøit tlaèítko pro towerData
            // pøidat .Click událost pøi kliknutí
        }
    }
}

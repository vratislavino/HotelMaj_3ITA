using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(
    fileName = "Building Data", 
    menuName = "BuildingData", 
    order = 0)]
public class BuildingScriptable : ScriptableObject
{
    public List<TowerData> data;
}

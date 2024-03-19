using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    /*
     
    TODO: Cannot call CreateBuildingPlaceholder from button
     
     */
    Camera mainCamera;

    [SerializeField]
    private GameObject buildingPlaceHolder;

    private GameObject currentPlaceholder;

    public void Test() {

        currentPlaceholder = Instantiate(buildingPlaceHolder);
    }

    public void CreateBuildingPlaceholder(BuildingType buildingType)
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPlaceholder != null) {
            currentPlaceholder.transform.position = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        }
    }
}
public enum BuildingType
{
    Policeman
}
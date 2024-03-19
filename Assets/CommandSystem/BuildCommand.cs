using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildCommand : Command
{
    private Building building;
    private Vector3 position;

    public BuildCommand(Building building, Vector3 position) {
        this.building = building;
        this.position = position;
    }

    public override void Execute()
    {
        building.Build(position);
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentBuilding : MonoBehaviour {

    private ObjectiveBuilding currentBuilding;

    public void SetCurrentBuilding(ObjectiveBuilding oB)
    {
        currentBuilding = oB;
    }

    // When button is clicked, package delivery is completed and the gameobject is deactivated
    public void GivePackage()
    {
        currentBuilding.CompleteCurrentBuildining();
        currentBuilding = null;
        gameObject.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageCalc : MonoBehaviour {
    public int packageDeliveryAmount;
    int packagesDelivered = 0;
    public Timer t;

    public void deliverPackage() {
        packagesDelivered++;
        if(packagesDelivered >= packageDeliveryAmount) {
            //endGame(t.timer)
        }
    }

	private void OnGUI() {
        GUI.Label(
            new Rect(10, 30, 250, 100),
            packagesDelivered + "/" + packageDeliveryAmount
        );
	}
}

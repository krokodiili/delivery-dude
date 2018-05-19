using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public float timer;
    string formattedTimer;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        formattedTimer = string.Format("{0}:{1}", minutes, seconds);

        print(formattedTimer);

	}

	private void OnGUI() {
        GUI.Label(new Rect(10, 10, 250, 100), formattedTimer);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveBuilding : MonoBehaviour {

    public Sprite buildingInside;
    public GameObject buildingInsideGO;

    private void Start()
    {
        BoxCollider2D bc2d = gameObject.AddComponent<BoxCollider2D>();
        bc2d.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerMovement>().SetAllowMovement(false);
            LoadBuildingInside();
        }
    }

    public void CompleteCurrentBuildining()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().SetAllowMovement(true);
        gameObject.GetComponent<AudioSource>().Stop();
    }
    
    private void LoadBuildingInside()
    {
        gameObject.GetComponent<AudioSource>().Play();
        buildingInsideGO.GetComponent<CurrentBuilding>().SetCurrentBuilding(gameObject.GetComponent<ObjectiveBuilding>());

        buildingInsideGO.SetActive(true);
        Image insideImage = buildingInsideGO.GetComponentInChildren<Image>();
        insideImage.sprite = buildingInside;
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lifeManager : MonoBehaviour {

    public GameObject slider;
    public GameObject soldierGameObject;
    Soldier sdInstance;
    Slider sldr;

	// Use this for initialization
	void Start () {
        sdInstance = soldierGameObject.GetComponent<Soldier>();
        sldr = slider.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        sldr.value = sdInstance.life;
	}
}

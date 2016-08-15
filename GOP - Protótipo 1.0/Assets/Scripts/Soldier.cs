using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Soldier : MonoBehaviour {


    //Public stuff
    public GameObject lifeSliderObject;
    public enum Type {defender, warrior, archer}
    public Type type;
    public int life = 100;
    public int attack = 0;
    public int attackBonus = 0;
    public int defense = 0;
    public int defenseBonus = 0;
    public int velocity = 0;
    public int cost = 0;

    //private stuff
    int castleId = -1;
    Slider lifeSlider;
    
	// Use this for initialization
	void Start () {
        lifeSlider = lifeSliderObject.GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        lifeSlider.value = life;
	}

    void OnMouseUp() {
        InputManager.setSelectedGameObject(gameObject);
    }
}

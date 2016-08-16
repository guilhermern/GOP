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
    public float velocity = 1.5f;
    public int cost = 0;

    //private stuff
    int castleId = -1;
    Slider lifeSlider;

    bool moveToDestiny = false;
    Vector3 target;


    

	// Use this for initialization
	void Start () {
        lifeSlider = lifeSliderObject.GetComponent<Slider>();
        target = transform.position;
	}



	void Update () {
        lifeSlider.value = life;
        moveToDestination();
	}

    void OnMouseUp() {
        InputManager.setSelectedGameObject(gameObject);
    }

    public void setDestiny(Vector3 mPos) {
        target = Camera.main.ScreenToWorldPoint(mPos);
        target.z = transform.position.z;
        moveToDestiny = true;
    }

    void moveToDestination() {
        if (moveToDestiny)
            transform.position = Vector3.MoveTowards(transform.position, target, velocity * Time.deltaTime);
    }

}

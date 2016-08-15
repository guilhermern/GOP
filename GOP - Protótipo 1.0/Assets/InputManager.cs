using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public static GameObject selectedObject = null;

    static public void setSelectedGameObject(GameObject obj) {
        selectedObject = obj;
        selectedObject.GetComponent<Soldier>().lifeSliderObject.SetActive(true);
    }

    static void setUnselected() {
        selectedObject.GetComponent<Soldier>().lifeSliderObject.SetActive(false);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            
        }
    }
    
	
}

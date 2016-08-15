using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public static GameObject selectedObject = null;

    static public void setSelectedGameObject(GameObject obj) {
        selectedObject = obj;
        selectedObject.GetComponent<Soldier>().lifeSliderObject.SetActive(true);
    }

    static void setUnselected() {
        if (selectedObject != null)
        {
            selectedObject.GetComponent<Soldier>().lifeSliderObject.SetActive(false);
            selectedObject = null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            setUnselected();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //movement
        }
    }
    
	
}

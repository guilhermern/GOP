using UnityEngine;
using System.Collections;

public class positioning : MonoBehaviour {

    public GameObject soldier;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = Camera.main.WorldToScreenPoint(soldier.transform.position);
        transform.position = pos;
	
	}
}

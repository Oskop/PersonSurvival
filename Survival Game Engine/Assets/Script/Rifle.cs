using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour {
	[SerializeField]
	int _damageDealt = 50;

	// Use this for initialization
	void Start () {
		// Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () {
		// if (Input.GetKey (KeyCode.K)){
		// 	Screen.lockCursor = false;
		// }
		// Ray mouseRay = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		// RaycastHit hitInfo;
		// if (Physics.Raycast(mouseRay, out hitInfo))
		// {
		// 	Debug.Log (hitInfo.transform.name);
		// }

		if (Input.GetButtonDown("Fire1")){
			// Screen.lockCursor = true;
			Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if (Physics.Raycast(mouseRay, out hitInfo)){ 
				Debug.Log (hitInfo.transform.name);
				Health enemyHealth = hitInfo.transform.GetComponent<Health>();
				if (enemyHealth != null){
					enemyHealth.Damage (_damageDealt);
				}
			}
		}
	}
}

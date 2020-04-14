// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Musuh1Collision : MonoBehaviour {

// 	void OnCollisionEnter(Collision col) {
// 		if (col.gameObject.tag == "Player"){
// 			Debug.Log("Collide");
// 			AudioSource aud = gameObject.GetComponent<AudioSource> ();
// 			aud.Play();
// 			// col.gameObject.SetActive (false);
//             // gameObject.SetActive (false);
// 		}
// 	}

//     AudioSource Musuh;

// 	void Start() {
// 		GameObject obyek = GameObject.FindGameObjectWithTag("ObyekMusuh");
// 		GameObject obyek1 = GameObject.FindGameObjectWithTag("Musuh1");
// 		GameObject obyek2 = GameObject.FindGameObjectWithTag("Musuh2");
// 		GameObject obyek3 = GameObject.FindGameObjectWithTag("Musuh3");
// 	}

// 	void OnCollisionEnter(Collision col) {
// 		if (col.gameObject.tag == "ObyekMusuh"
// 			|| col.gameObject.tag == "Musuh1" 
// 			|| col.gameObject.tag == "Musuh2" 
// 			|| col.gameObject.tag == "Musuh3"){
// 			// ObyekMusuh = GameObject.FindGameObjectWithTag(col.gameObject.tag);
// 			Debug.Log("Collide");
// 			Debug.Log(col.gameObject.tag);
// 			// AudioSource aud = gameObject.GetComponent<AudioSource> ();
// 			AudioSource aud = col.gameObject.GetComponent<AudioSource> ();
// 			aud.Play();
// 			// col.gameObject.SetActive (false);
// 			col.gameObject.SetActive (false);
// 		} 
// 		// else if (col.gameObject.tag == "Musuh1")
// 		// {
// 		// 	Debug.Log("Collide");
// 		// 	// GameObject enemyObject = GameObject.FindGameObjectWithTag("ObyekMusuh");
// 		// 	AudioSource aud = col.gameObject.GetComponent<AudioSource> ();
// 		// 	aud.Play();
// 		// 	col.gameObject.SetActive (false);
// 		// }
// 	}
// }

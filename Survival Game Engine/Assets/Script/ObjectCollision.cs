using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {
	AudioSource obyek;
	AudioSource musuh1;
	AudioSource musuh2;
	AudioSource musuh3;

	void Start() {
		GameObject ss = GameObject.Find("ObyekMusuh");
		GameObject sss = GameObject.Find("Musuh1");
		GameObject ssss = GameObject.Find("Musuh2");
		GameObject sssss = GameObject.Find("Musuh3");
		obyek = ss.GetComponent<AudioSource>();
		musuh1 = sss.GetComponent<AudioSource>();
		musuh2 = ssss.GetComponent<AudioSource>();
		musuh3 = sssss.GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "ObyekMusuh"
			|| col.gameObject.tag == "Musuh1"
			|| col.gameObject.tag == "Musuh2"
			|| col.gameObject.tag == "Musuh3"
			) {
			Debug.Log("Collide");
			
			// AudioSource aud = audio.GetComponent<AudioSource> ();
			// Debug.Log(aud.tag);
			if (col.gameObject.tag == "ObyekMusuh"){obyek.Play();Debug.Log(obyek.tag);} 
			else if (col.gameObject.tag == "Musuh1"){musuh1.Play();Debug.Log(musuh1.tag);}
			else if (col.gameObject.tag == "Musuh2"){musuh2.Play();Debug.Log(musuh2.tag);}
			else if (col.gameObject.tag == "Musuh3"){musuh3.Play();Debug.Log(musuh3.tag);}
			col.gameObject.SetActive (false);
            // gameObject.SetActive (false);
		}
	}
}

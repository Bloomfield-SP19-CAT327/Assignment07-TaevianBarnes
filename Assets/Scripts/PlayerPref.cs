using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour {
	public int testValue;

	// Start is called before the first frame update
	void Start() {
		Debug.Log("PDP: " + Application.persistentDataPath);
		testValue = (PlayerPrefs.HasKey("Test")) ? PlayerPrefs.GetInt("Test") : 0;
		Debug.Log(testValue);
	}

	// Update is called once per frame
	void Update() {

	}

	public void SavePlayerPrefs() {
		PlayerPrefs.Save();
		Debug.Log("Saving PlayerPrefs");
	}

	public void DeletePlayerPrefs() {
		PlayerPrefs.DeleteAll();
		PlayerPrefs.Save();
		Debug.Log("Deleting All PlayerPrefs");
	}

	private void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.tag == "Collectable") {
			PlayerPrefs.SetInt("Test", ++testValue);
			Debug.Log(PlayerPrefs.GetInt("Test").ToString());
		}
	}
}


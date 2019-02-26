using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPref : MonoBehaviour
{
    public int testValue;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Test", 5);

        PlayerPrefs.GetInt("Test");
        Debug.Log(PlayerPrefs.GetInt("Test").ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            PlayerPrefs.SetInt("Test", testValue++);

            Debug.Log(PlayerPrefs.GetInt("Test").ToString());
        }

    }
}


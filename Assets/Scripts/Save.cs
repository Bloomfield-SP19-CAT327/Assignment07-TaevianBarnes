using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    private int number;

    // Start is called before the first frame update


    // Update is called once per frame
    public void SaveGame()
    {
        PlayerPrefs.Save("Test", number);
    }
}

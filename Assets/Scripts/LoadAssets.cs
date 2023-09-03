using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    [SerializeField]
    private GameObject redObj; 
    [SerializeField]
    private GameObject blueObj; 

    void Start()
    {
        Application.targetFrameRate = 60;


        GameObject redObject = Instantiate(redObj, new Vector3(2f, 0f, 0f), Quaternion.identity);

        GameObject blueObject = Instantiate(blueObj, new Vector3(-2f, 0f, 0f), Quaternion.identity);
    }
}
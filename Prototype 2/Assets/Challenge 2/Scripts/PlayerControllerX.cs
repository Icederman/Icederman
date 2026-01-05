using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeInterval = 2.0f;
    private float nextTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextTime)
        {
            nextTime = Time.time + timeInterval;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
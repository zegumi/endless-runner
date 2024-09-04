using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;
    // objectToFollow kameranın hangi objeyi takip edeceğini anlatan değişken değeri
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = objectToFollow.transform.position - (Vector3.forward * 10) + (Vector3.up * 5);
        // transform.position - kameranın pozisyonu
    }
}

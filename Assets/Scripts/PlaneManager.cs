using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneManager : MonoBehaviour
{
    public GameObject planePrefab;

    public void SpawnNextPlane(Vector3 planeSpawnPosition){
        
        Instantiate(planePrefab, planeSpawnPosition,Quaternion.identity); 

    }
}

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public PlaneManager planeManager;
    public GameObject spawnLocationObject;
    
   private void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.name.Equals("Player"))
    {
       
        planeManager.SpawnNextPlane(spawnLocationObject.transform.position);
    }
   }
  
}

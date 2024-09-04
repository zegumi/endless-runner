using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
   private void OnBecameInvisible()
   {
    Debug.Log("Silindi");
    Destroy(gameObject);
   }
}

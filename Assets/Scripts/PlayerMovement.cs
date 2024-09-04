using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rgb;
    private float moveSpeed; 
    private float jumpSpeed;
    private float gravityScale;
    private float slideSpeed;
    private int laneIndex;
    // Start is called before the first frame update
    void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        moveSpeed = 10f;
        jumpSpeed = 60f;
        gravityScale = 40f;
        slideSpeed = 100f;
        laneIndex = 0;
        

        // f kat sayısı ile çarpılarak ilerliyecek
    }

   private void Update()
   {
   rgb.AddForce(Vector3.forward * moveSpeed, ForceMode.Force);
   rgb.AddForce(Physics.gravity * gravityScale * Time.fixedDeltaTime, ForceMode.Acceleration);
   if (Input.GetButtonDown("Jump") && rgb.velocity.y == 0)
   // rgb.velocity.y == 0 space i spamlerken karakterin uçmaması için
    {
        rgb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }
    if (Input.GetKeyDown(KeyCode.D))
    {
        if (laneIndex!=1)
        {
            rgb.AddForce(Vector3.right * slideSpeed, ForceMode.Impulse);
            laneIndex++;
        }
        
    }
      if (Input.GetKeyDown(KeyCode.A))
    {
        if (laneIndex!=-1)
        {
            rgb.AddForce(Vector3.left * slideSpeed, ForceMode.Impulse);
            laneIndex--;
        }
        
        
    }
        
   }
   
}

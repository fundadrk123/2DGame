using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;// pizam için üst sýnýr.
    private float lowerBound = -10; // hayvanlarým için alt sýnýr.
   
    void Start()
    {
       
    }

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
            Debug.Log("pizza yok edildi");
        }else if(transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("hayvanlar yok edildi"); //! buraya oyun sonunda tekrar dön kodun çalýþmýyor.
        }
        
    }
}

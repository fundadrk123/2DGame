using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;// pizam i�in �st s�n�r.
    private float lowerBound = -10; // hayvanlar�m i�in alt s�n�r.
   
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
            Debug.Log("hayvanlar yok edildi"); //! buraya oyun sonunda tekrar d�n kodun �al��m�yor.
        }
        
    }
}

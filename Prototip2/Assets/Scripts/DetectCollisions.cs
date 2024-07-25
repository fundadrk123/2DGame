using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;

public class DetectCollisions : MonoBehaviour
{
    public Score score;

    private void OnTriggerEnter(Collider other)
    {
        
       
            if (other.CompareTag("obstacle"))
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
                Score.score.Scored();
            }
       
    }

}

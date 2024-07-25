using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f; // oyuncu hýz kontrolüm.
    public float xRange = 19.0f; // oyuncumun sahne aralýðý.
    public GameObject projetilePrefab;
    



    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed); // oyuncumu saða ve sola harekettini saðlayýp kontrol etmek için.
        transform.Translate(Vector3.back * verticalInput * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetilePrefab, transform.position, projetilePrefab.transform.rotation); // mermimizi ürettik.
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door"))
        {
            Destroy(gameObject);
            Debug.Log("djhdkn");
        }
    }

}
   
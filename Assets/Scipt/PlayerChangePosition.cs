using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    [SerializeField] private Camera cam;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Area2")
        { Vector3 camPosition = new Vector3(0,-11.01f, -10f);
            cam.transform.position = camPosition;

          Vector3 playerPosition = new Vector3(-0.02f,-7.83f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(0, 0.07f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-0.02f, -3.97f, 0);
            this.transform.position = playerPosition;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangePosition : MonoBehaviour
{
    [SerializeField] private Camera cam;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Area2")
        { Vector3 camPosition = new Vector3(0,-10.93f, -10f);
            cam.transform.position = camPosition;

          Vector3 playerPosition = new Vector3(0,- 6.96f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(0, 0, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(-0.94f, -4.05f, 0);
            this.transform.position = playerPosition;
        }
    }


}

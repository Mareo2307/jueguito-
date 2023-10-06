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

        if (collision.gameObject.tag == "Area3")
        {
            Vector3 camPosition = new Vector3(20.55f, -11.05f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(13.23f, -10.15f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area2.2")
        {
            Vector3 camPosition = new Vector3(0, -11.01f, -10f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(6.55f, -10.75f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area4")
        {
            Vector3 camPosition = new Vector3(20.56f, 0.1f, 0f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(17.43f, -3.86f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area4.2")
        {
            Vector3 camPosition = new Vector3(20.56f, 0.1f, 0f);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(25.65f, -3.64f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area3.2")
        {
            Vector3 camPosition = new Vector3(20.55f, -11.05f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(17.53f, -7.36f, 0);
            this.transform.position = playerPosition;
        }

        if (collision.gameObject.tag == "Area3.3")
        {
            Vector3 camPosition = new Vector3(20.55f, -11.05f, -10);
            cam.transform.position = camPosition;

            Vector3 playerPosition = new Vector3(25.73f, -7.36f, 0);
            this.transform.position = playerPosition;
        }




    }


}

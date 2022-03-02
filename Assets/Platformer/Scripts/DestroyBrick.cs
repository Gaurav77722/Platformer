using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DestroyBrick : MonoBehaviour
{
    private GameObject mario;
    private bool destroyed;
    
    // Update is called once per frame
    void Update ()
    {
        destroyed = false;
        mario = GameObject.Find("Mario");
        RaycastHit hit;
        Points cs = GameObject.Find("Text (TMP)").GetComponent<Points>();
        
        // cast a ray from the camera in the given direction
            if (Physics.Raycast (mario.transform.position, Vector3.up*1.1f, out hit, 2f)) {

                Debug.DrawLine (mario.transform.position, hit.point, Color.green, 0.5f);

            // Destroy game object
                if (hit.collider.gameObject.tag == "Brick")
                {
                    destroyed = true;
                    Destroy (hit.collider.gameObject);
                }

                if (destroyed)
                {
                    cs.scoreInc();
                }

            } 
        }
    }


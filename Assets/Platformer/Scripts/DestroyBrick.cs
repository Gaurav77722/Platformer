using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DestroyBrick : MonoBehaviour
{

    

    // Update is called once per frame
    void Update () {

        // Test for mouse click
        if (Input.GetMouseButtonUp (0)) {

        // get mouse position in world space
            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 100f));

        // get direction vector from camera position to mouse position in world space
            Vector3 direction = worldMousePosition - Camera.main.transform.position;

            RaycastHit hit;

            // cast a ray from the camera in the given direction
            if (Physics.Raycast (Camera.main.transform.position, direction, out hit, 100f)) {

                Debug.DrawLine (Camera.main.transform.position, hit.point, Color.green, 0.5f);

            // Destroy game object
                if (hit.collider.gameObject.tag == "Brick") {
                    Destroy (hit.collider.gameObject);
                }

            } else {
                Debug.DrawLine (Camera.main.transform.position, worldMousePosition, Color.red, 0.5f);
            }
        }
    }

    
}

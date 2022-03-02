using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    [SerializeField] private TMP_Text questionCounter;
    private int coins = 0;
    private GameObject mario;
    RaycastHit hit;
    
    // Update is called once per frame
    void FixedUpdate()
    {
            mario = GameObject.Find("Mario");

            Points cs = GameObject.Find("Text (TMP)").GetComponent<Points>();

            // cast a ray from the camera in the given direction
            if (Physics.Raycast (mario.transform.position, Vector3.up, out hit, 1.76f)) 
            {

                Debug.DrawLine(mario.transform.position, hit.point, Color.green, 0.1f);
                // Destroy game object
                if (hit.collider.gameObject.tag == "Question")
                {
                    coins++;
                    questionCounter.SetText("x" + coins.ToString());
                    cs.scoreInc();
                }
                
            }
        }
    
}

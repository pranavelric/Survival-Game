using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorLogic : MonoBehaviour
{
    public Transform theDoor;
    private bool drawGUI = false;
    private bool doorisclosed = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (drawGUI == true && Input.GetKeyDown(KeyCode.E))
        {
            changeDoorState();
        }

    }

    void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.tag == "Player")
        {
            Debug.Log("working");
            drawGUI = true;
        }

    }
    void OnTriggerExit(Collider theCollider)
    {
        if (theCollider.tag == "Player")
        {

            drawGUI = false;
        }
    }
    void OnGUI()
    {
        if (drawGUI == true)
        {
            GUI.Box(new Rect((int)(Screen.width * 0.5) - 51, 200, 102, 22), "Press E to open");
        }
        else
        {

        }
    }

    void changeDoorState()
    {
        if (doorisclosed == true)
        {
            // theDoor.animation.crossfade("open");
        }
    }

}

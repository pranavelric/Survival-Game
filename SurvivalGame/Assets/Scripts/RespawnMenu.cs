using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnMenu : MonoBehaviour
{



    public GameObject player;
    public static bool isplayerdead = false;
    // Start is called before the first frame update
    void Start()
    {
        // lookAround01 = gameObject.GetComponent("RigidbodyFirstPersonController").GetComponent("Mouse Look");

    }

    // Update is called once per frame
    void Update()
    {
        if (isplayerdead == true)
        {
            Cursor.lockState = CursorLockMode.None;

            player.GetComponent<UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController>().enabled = false;
            // (player.GetComponent("RigidBodyFirstPersonController") as MonoBehaviour).enabled = false;
            // UnityStandardAssets.Characters.FirstPerson.MouseLook.lockCursor = false;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;


        }

    }
    void RespawnPLayer()
    {
        Debug.Log("REspawefn");
    }
    void OnGUI()
    {
        if (isplayerdead == true)
        {
            if (GUI.Button(new Rect((int)(Screen.width * 0.5 - 50), 200 - 20, 100, 40), "You die")
          )
            {
                RespawnPLayer();
            }
            if (GUI.Button(new Rect((int)(Screen.width * 0.5 - 50), 240, 100, 40), "Got to menu")
                )
            {
                Menu();
            }
        }
    }
    void Menu()
    {

    }
}

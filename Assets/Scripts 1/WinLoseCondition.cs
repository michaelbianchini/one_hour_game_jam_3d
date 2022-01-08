using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour
{
    UnityEngine.UI.Text WinMessage;
    string WinMessageString = "You eat the Magic Meatball and escape the Horrible Maze of IKEA";
    // Start is called before the first frame update
    void Start()
    {
        // Load the Arial font from the Unity Resources folder.
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");

        // Create Canvas GameObject.
        GameObject canvasGO = new GameObject();
        canvasGO.name = "Canvas";
        canvasGO.AddComponent<Canvas>();
        //canvasGO.AddComponent<CanvasScaler>();
        //canvasGO.AddComponent<GraphicRaycaster>();

        // Get canvas from the GameObject.
        Canvas canvas;
        canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = canvasGO.transform;
        textGO.AddComponent<UnityEngine.UI.Text>();

        // Set Text component properties.
        WinMessage = textGO.GetComponent<UnityEngine.UI.Text>();
        WinMessage.font = arial;
        WinMessage.text = "You are trapped in IKEA!  Find the Swedish Meatball of Deliverance!";
        WinMessage.fontSize = 48;
        WinMessage.color = Color.red;
        WinMessage.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = WinMessage.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, 0, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Sphere")
        {
            UnityEngine.UI.Text.Instantiate(WinMessage);
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Win");
            WinMessage.color = Color.green;
            WinMessage.text = WinMessageString;
        }
    }
}

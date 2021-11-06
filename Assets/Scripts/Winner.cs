using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{

    public GameObject finishLine;
    public UnityEngine.UI.Text winMessage;
    private static bool winnerFound = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == finishLine)
        {
            if (winnerFound == false) {
                Debug.Log(this.gameObject.name + "Wins!");
                winMessage.text = this.gameObject.name + "Wins!";
                winnerFound = true;
            }
        }
        else { Debug.Log("You collided with something else"); }

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("hello");
    }
}

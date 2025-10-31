using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of object

        /*Hi there!
        * this is two lines
        **/
        Debug.Log(transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        
        //make an if statement that checks the height of my object
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground");
        }
    }
}

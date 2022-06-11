using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public float movementspeed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement

        var movemenet = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movemenet, 0, 0) * Time.deltaTime * movementspeed;

        //flip

         Vector3 characterscale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterscale.x = -8f; /// -xf     x = scale the character is currently in. 
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterscale.x = 8f;
        }
        transform.localScale = characterscale;

    }
}

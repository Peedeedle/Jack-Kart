////////////////////////////////////////////////////////////
// File: KartWallTrigger.cs
// Author: Jack Peedle
// Date Created: 28/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 28/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartWallTrigger : MonoBehaviour {

    public JackKartAgent jackKartAgent;

    public void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag == "Wall") {

            //Debug.Log("Collided With Wall");

            jackKartAgent.CollidedWithWall();

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

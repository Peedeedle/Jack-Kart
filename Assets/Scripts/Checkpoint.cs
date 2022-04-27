////////////////////////////////////////////////////////////
// File: Checkpoint.cs
// Author: Jack Peedle
// Date Created: 14/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 27/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    
    private void OnTriggerEnter(Collider other) {
        
        // if other component in trigger has CheckpointManager component
        if (other.GetComponent<CheckpointManager>() != null) {

            // component.checkpointreached
            other.GetComponent<CheckpointManager>().CheckPointReached(this);

        }

    }


}

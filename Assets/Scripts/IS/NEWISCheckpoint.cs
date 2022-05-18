////////////////////////////////////////////////////////////
// File: Checkpoint.cs
// Author: Jack Peedle
// Date Created: 18/05/22
// Last Edited By: Jack Peedle
// Date Last Edited: 18/05/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWISCheckpoint : MonoBehaviour {

    
    private void OnTriggerEnter(Collider other) {
        
        // if other component in trigger has CheckpointManager component
        if (other.GetComponent<NEWISCheckpointManager>() != null) {

            // component.checkpointreached
            other.GetComponent<NEWISCheckpointManager>().CheckPointReached(this);

        }

    }


}

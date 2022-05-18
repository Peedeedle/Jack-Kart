////////////////////////////////////////////////////////////
// File: NEWISCheckpoints.cs
// Author: Jack Peedle
// Date Created: 18/05/22
// Last Edited By: Jack Peedle
// Date Last Edited: 18/05/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWISCheckpoints : MonoBehaviour {

    // List of checkpoints
    public List<NEWISCheckpoint> checkPoints;

    private void Awake() {

        // set the checkpoints to the children with the component of Checkpoint
        checkPoints = new List<NEWISCheckpoint>(GetComponentsInChildren<NEWISCheckpoint>());

    }
}

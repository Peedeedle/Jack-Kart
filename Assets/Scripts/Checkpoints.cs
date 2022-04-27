////////////////////////////////////////////////////////////
// File: Checkpoints.cs
// Author: Jack Peedle
// Date Created: 14/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 27/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour {

    // List of checkpoints
    public List<Checkpoint> checkPoints;

    private void Awake() {

        // set the checkpoints to the children with the component of Checkpoint
        checkPoints = new List<Checkpoint>(GetComponentsInChildren<Checkpoint>());

    }
}

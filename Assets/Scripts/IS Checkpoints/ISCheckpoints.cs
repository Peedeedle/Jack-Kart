////////////////////////////////////////////////////////////
// File: Checkpoints.cs
// Author: Jack Peedle
// Date Created: 13/05/22
// Last Edited By: Jack Peedle
// Date Last Edited: 13/05/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISCheckpoints : MonoBehaviour {

    // List of checkpoints
    public List<CerealCP> checkPoints;

    private void Awake() {

        // set the checkpoints to the children with the component of Checkpoint
        checkPoints = new List<CerealCP>(GetComponentsInChildren<CerealCP>());

    }
}

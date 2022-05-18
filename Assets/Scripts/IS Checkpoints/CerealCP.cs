////////////////////////////////////////////////////////////
// File: CerealCP.cs
// Author: Jack Peedle
// Date Created: 13/05/22
// Last Edited By: Jack Peedle
// Date Last Edited: 13/05/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealCP : MonoBehaviour {

    
    private void OnTriggerEnter(Collider other) {
        
        // if other component in trigger has CheckpointManager component
        if (other.GetComponent<CerealCPManager>() != null) {

            // component.checkpointreached
            other.GetComponent<CerealCPManager>().CheckPointReached(this);

        }

    }


}

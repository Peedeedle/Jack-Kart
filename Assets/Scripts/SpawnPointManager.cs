////////////////////////////////////////////////////////////
// File: SpawnPointManager.cs
// Author: Jack Peedle
// Date Created: 14/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 27/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{

    public Transform[] spawnPoints;

    public Vector3 SelectRandomSpawnpoint() {

        // select random spawn point
        int rnd = Random.Range(0, spawnPoints.Length);
        return spawnPoints[rnd].position;

    }
}

////////////////////////////////////////////////////////////
// File: CheckpointManager.cs
// Author: Jack Peedle
// Date Created: 14/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 27/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerealCPManager : MonoBehaviour {

    // Kart agent and next checkpoint
    public JackKartAgent jackKartAgent;
    public CerealCP nextCerealCheckPointToReach;

    // current checkpoint, checkpoint list, last checkpoint
    private int CurrentCheckpointIndex;
    private List<CerealCP> Checkpoints;
    private CerealCP lastCheckpoint;

    // event for when the agent reaches the checkpoint
    public event Action<CerealCP> reachedCerealCheckpoint;

    void Start() {

        // Find all checkpoints and reset them
        Checkpoints = FindObjectOfType<ISCheckpoints>().checkPoints;
        ResetCheckpoints();

    }

    public void ResetCheckpoints() {

        // current checkpoint = 0, time to next checkpoint = 30f
        CurrentCheckpointIndex = 0;

        // Set next checkpoint
        SetNextCheckpoint();

    }

    private void Update() {



        // give negative reward and end episode
        //jackKartAgent.AddReward(-1f);
        //jackKartAgent.EndEpisode();


    }

    // When reached a checkpoint
    public void CheckPointReached(CerealCP checkpoint) {

        // if next checkpoint to reach is not equal to a checkpoint
        if (nextCerealCheckPointToReach != checkpoint) {

            return;

        }

        // if the checkpoint was reached, increment the checkpoint by 1
        lastCheckpoint = Checkpoints[CurrentCheckpointIndex];
        reachedCerealCheckpoint?.Invoke(checkpoint);
        CurrentCheckpointIndex++;

        // if the current checkpoint is more than the checkpoint list
        if (CurrentCheckpointIndex >= Checkpoints.Count) {

            // give the agent a reward and restart the episode
            jackKartAgent.AddReward(0.5f);
            jackKartAgent.EndEpisode();

        } else {

            // reward the agent divided by the checkpoints they hit, set next checkpoint
            jackKartAgent.AddReward((0.5f) / Checkpoints.Count);
            SetNextCheckpoint();

        }
    }

    private void SetNextCheckpoint() {

        // if the checkpoint count is more than 0
        if (Checkpoints.Count > 0) {

            // set time left to 30f(reset)
            // allocate next checkpoint to reach
            nextCerealCheckPointToReach = Checkpoints[CurrentCheckpointIndex];

        }

    }

}

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

public class CheckpointManager : MonoBehaviour {

    // Time left and max time to reach the next checkpoint
    public float MaxTimeToReachNextCheckpoint = 30f;
    public float TimeLeft = 30f;

    // Kart agent and next checkpoint
    public JackKartAgent jackKartAgent;
    public Checkpoint nextCheckPointToReach;

    // current checkpoint, checkpoint list, last checkpoint
    private int CurrentCheckpointIndex;
    private List<Checkpoint> Checkpoints;
    private Checkpoint lastCheckpoint;

    // event for when the agent reaches the checkpoint
    public event Action<Checkpoint> reachedCheckpoint;

    void Start() {

        // Find all checkpoints and reset them
        Checkpoints = FindObjectOfType<Checkpoints>().checkPoints;
        ResetCheckpoints();

    }

    public void ResetCheckpoints() {

        // current checkpoint = 0, time to next checkpoint = 30f
        CurrentCheckpointIndex = 0;
        TimeLeft = MaxTimeToReachNextCheckpoint;

        // Set next checkpoint
        SetNextCheckpoint();

    }

    private void Update() {

        TimeLeft -= Time.deltaTime;

        // if time left is less than 0
        if (TimeLeft < 0f) {

            // give negative reward and end episode
            jackKartAgent.AddReward(-1f);
            jackKartAgent.EndEpisode();

        }

    }

    // When reached a checkpoint
    public void CheckPointReached(Checkpoint checkpoint) {

        // if next checkpoint to reach is not equal to a checkpoint
        if (nextCheckPointToReach != checkpoint) {

            return;

        }

        // if the checkpoint was reached, increment the checkpoint by 1
        lastCheckpoint = Checkpoints[CurrentCheckpointIndex];
        reachedCheckpoint?.Invoke(checkpoint);
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
            TimeLeft = MaxTimeToReachNextCheckpoint;
            nextCheckPointToReach = Checkpoints[CurrentCheckpointIndex];

        }

    }

}

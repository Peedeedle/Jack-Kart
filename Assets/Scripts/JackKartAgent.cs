////////////////////////////////////////////////////////////
// File: KartAgent.cs
// Author: Jack Peedle
// Date Created: 14/04/22
// Last Edited By: Jack Peedle
// Date Last Edited: 27/04/22
// Brief:   
//////////////////////////////////////////////////////////// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class JackKartAgent : Agent {

    // CheckpointManager, KartController
    public CheckpointManager _checkpointManager;
    private KartController _kartController;

    public override void Initialize() {

        // get KartController script
        _kartController = GetComponent<KartController>();

    }

    public override void OnEpisodeBegin() {

        // Reset checkpoints, respawn Kart
        _checkpointManager.ResetCheckpoints();
        _kartController.Respawn();

    }

    public override void CollectObservations(VectorSensor sensor) {

        // vector 3 for the next checkpoint to reach
        // add a negative reward constantly
        Vector3 diff = _checkpointManager.nextCheckPointToReach.transform.position - transform.position;
        sensor.AddObservation(diff / 20f);
        AddReward(-0.001f);

    }

    public override void OnActionReceived(ActionBuffers actions) {

        // variable for continuous actions
        var Actions = actions.ContinuousActions;

        // apply acceleration, steer and animation actions
        _kartController.ApplyAcceleration(Actions[1]);
        _kartController.Steer(Actions[0]);
        //_kartController.AnimateKart(Actions[0]);

    }

    public override void Heuristic(in ActionBuffers actionsOut) {

        // variable for continuous actions
        // Heuristic (player not AI)
        var continousActions = actionsOut.ContinuousActions;
        continousActions.Clear();

        // horizontal and forward movement
        continousActions[0] = Input.GetAxis("Horizontal");
        continousActions[1] = Input.GetKey(KeyCode.W) ? 1f : 0f;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISRandomPlacement : MonoBehaviour
{

    public Transform[] positionsToMoveTo;

    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
    public GameObject Object4;

    private void Start() {
        
        int rand = Random.Range(0, positionsToMoveTo.Length);

        Object1.transform.position = positionsToMoveTo[rand].transform.position;
        Object2.transform.position = positionsToMoveTo[rand].transform.position;
        Object3.transform.position = positionsToMoveTo[rand].transform.position;
        Object4.transform.position = positionsToMoveTo[rand].transform.position;

    }

}

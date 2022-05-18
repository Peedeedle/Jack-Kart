using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    //public Transform[] spawnSpots;
    //private int randomSpawnSpot1;
    //private int x = 0;

    public GameObject[] isPrefabs;
    public GameObject[] isGOPrefabs;

    ///public GameObject prefab1;
    ///public GameObject prefab2;
    ///public GameObject prefab3;
    ///public GameObject prefab4;

    public void SpawnRandomISGO() {

        for (int positionInArray = 0; positionInArray < isPrefabs.Length; positionInArray++) {

            GameObject obj = isPrefabs[positionInArray];
            int randomArray = Random.Range(0, isPrefabs.Length);
            isPrefabs[positionInArray] = isPrefabs[randomArray];
            isPrefabs[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isGOPrefabs.Length; positionInArray++) {

            GameObject obj = isGOPrefabs[positionInArray];
            int randomArray = Random.Range(0, isGOPrefabs.Length);
            isGOPrefabs[positionInArray] = isGOPrefabs[randomArray];
            isGOPrefabs[randomArray] = obj;

        }

        isGOPrefabs[0].transform.position = isPrefabs[0].transform.position;
        isGOPrefabs[1].transform.position = isPrefabs[1].transform.position;
        isGOPrefabs[2].transform.position = isPrefabs[2].transform.position;
        isGOPrefabs[3].transform.position = isPrefabs[3].transform.position;

        //randomSpawnSpot1 = Random.Range(0, spawnSpots.Length);
        //prefab1.transform.position = spawnSpots[randomSpawnSpot1].transform.position;

        /*
        foreach (Transform spawnSpot in spawnSpots) {

            prefab1.transform.parent = spawnSpots[randomSpawnSpot1].transform;
            prefab1.transform.position = new Vector3(0, 0, 0);

            prefab2.transform.parent = spawnSpot.transform;
            prefab2.transform.position = new Vector3(0, 0, 0);

            prefab3.transform.parent = spawnSpot.transform;
            prefab3.transform.position = new Vector3(0, 0, 0);

            prefab4.transform.parent = spawnSpot.transform;
            prefab4.transform.position = new Vector3(0, 0, 0);

            //prefab1.transform.position = spawnSpot.position;
            //prefab2.transform.position = spawnSpot.position;
            //prefab3.transform.position = spawnSpot.position;
            //prefab4.transform.position = spawnSpot.position;

        }

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab1.transform.position = randomSpawnPosition;
        //Instantiate(prefab1, randomSpawnPosition, Quaternion.identity);

        Vector3 randomSpawnPosition2 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab2.transform.position = randomSpawnPosition2;
        //Instantiate(prefab2, randomSpawnPosition2, Quaternion.identity);

        Vector3 randomSpawnPosition3 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab3.transform.position = randomSpawnPosition3;
        //Instantiate(prefab3, randomSpawnPosition3, Quaternion.identity);

        Vector3 randomSpawnPosition4 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab4.transform.position = randomSpawnPosition4;
        //Instantiate(prefab4, randomSpawnPosition4, Quaternion.identity);

        */

    }

    /*
    public void SpawnRandomISGO() {

        Vector3 randomSpawnPosition = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab1.transform.position = randomSpawnPosition;
        //Instantiate(prefab1, randomSpawnPosition, Quaternion.identity);

        Vector3 randomSpawnPosition2 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab2.transform.position = randomSpawnPosition2;
        //Instantiate(prefab2, randomSpawnPosition2, Quaternion.identity);

        Vector3 randomSpawnPosition3 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab3.transform.position = randomSpawnPosition3;
        //Instantiate(prefab3, randomSpawnPosition3, Quaternion.identity);

        Vector3 randomSpawnPosition4 = new Vector3(Random.Range(-15, 15), 0, Random.Range(-15, 15));
        prefab4.transform.position = randomSpawnPosition4;
        //Instantiate(prefab4, randomSpawnPosition4, Quaternion.identity);

    }
    */

    /*
    public void DeleteInstantiatedPrefabs() {

        Destroy(prefab1.gameObject);
        Destroy(prefab2.gameObject);
        Destroy(prefab3.gameObject);
        Destroy(prefab4.gameObject);


    }
    */

}

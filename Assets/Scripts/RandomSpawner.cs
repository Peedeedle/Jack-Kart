using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    //public Transform[] spawnSpots;
    //private int randomSpawnSpot1;
    //private int x = 0;

    public GameObject[] isGOPositions1;
    public GameObject[] isGOPositions2;
    public GameObject[] isGOPositions3;
    public GameObject[] isGOPositions4;
    public GameObject[] isGOPositions5;
    public GameObject[] isGOPositions6;
    public GameObject[] isGOPositions7;
    public GameObject[] isGOPositions8;
    public GameObject[] isGOPositions9;
    public GameObject[] isGOPositions10;
    public GameObject[] isGOPositions11;
    public GameObject[] isGOPositions12;
    public GameObject[] isGOPositions13;
    public GameObject[] isGOPositions14;
    public GameObject[] isGOPositions15;
    public GameObject[] isGOPositions16;
    public GameObject[] isGOPositions17;
    public GameObject[] isGOPositions18;
    public GameObject[] isGOPositions19;
    public GameObject[] isGOPositions20;
    public GameObject[] isGOPositions21;
    public GameObject[] isGOPositions22;
    public GameObject[] isGOPositions23;


    public GameObject[] isPrefabs1;
    public GameObject[] isPrefabs2;
    public GameObject[] isPrefabs3;
    public GameObject[] isPrefabs4;
    public GameObject[] isPrefabs5;
    public GameObject[] isPrefabs6;
    public GameObject[] isPrefabs7;
    public GameObject[] isPrefabs8;
    public GameObject[] isPrefabs9;
    public GameObject[] isPrefabs10;
    public GameObject[] isPrefabs11;
    public GameObject[] isPrefabs12;
    public GameObject[] isPrefabs13;
    public GameObject[] isPrefabs14;
    public GameObject[] isPrefabs15;
    public GameObject[] isPrefabs16;
    public GameObject[] isPrefabs17;
    public GameObject[] isPrefabs18;
    public GameObject[] isPrefabs19;
    public GameObject[] isPrefabs20;
    public GameObject[] isPrefabs21;
    public GameObject[] isPrefabs22;
    public GameObject[] isPrefabs23;

    ///public GameObject prefab1;
    ///public GameObject prefab2;
    ///public GameObject prefab3;
    ///public GameObject prefab4;

    public void SpawnRandomISGO() {

        #region Random1
        for (int positionInArray = 0; positionInArray < isGOPositions1.Length; positionInArray++) {

            GameObject obj = isGOPositions1[positionInArray];
            int randomArray = Random.Range(0, isGOPositions1.Length);
            isGOPositions1[positionInArray] = isGOPositions1[randomArray];
            isGOPositions1[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs1.Length; positionInArray++) {

            GameObject obj = isPrefabs1[positionInArray];
            int randomArray = Random.Range(0, isPrefabs1.Length);
            isPrefabs1[positionInArray] = isPrefabs1[randomArray];
            isPrefabs1[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs1[0].transform.position = isGOPositions1[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs1[1].transform.position = isGOPositions1[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs1[2].transform.position = isGOPositions1[2].transform.position;

        #endregion

        #region Random2
        for (int positionInArray = 0; positionInArray < isGOPositions2.Length; positionInArray++) {

            GameObject obj = isGOPositions2[positionInArray];
            int randomArray = Random.Range(0, isGOPositions2.Length);
            isGOPositions2[positionInArray] = isGOPositions2[randomArray];
            isGOPositions2[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs2.Length; positionInArray++) {

            GameObject obj = isPrefabs2[positionInArray];
            int randomArray = Random.Range(0, isPrefabs2.Length);
            isPrefabs2[positionInArray] = isPrefabs2[randomArray];
            isPrefabs2[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs2[0].transform.position = isGOPositions2[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[4].transform;
        isPrefabs2[1].transform.position = isGOPositions2[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs2[2].transform.position = isGOPositions2[2].transform.position;

        #endregion

        #region Random3
        for (int positionInArray = 0; positionInArray < isGOPositions3.Length; positionInArray++) {

            GameObject obj = isGOPositions3[positionInArray];
            int randomArray = Random.Range(0, isGOPositions3.Length);
            isGOPositions3[positionInArray] = isGOPositions3[randomArray];
            isGOPositions3[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs3.Length; positionInArray++) {

            GameObject obj = isPrefabs3[positionInArray];
            int randomArray = Random.Range(0, isPrefabs3.Length);
            isPrefabs3[positionInArray] = isPrefabs3[randomArray];
            isPrefabs3[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs3[0].transform.position = isGOPositions3[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs3[1].transform.position = isGOPositions3[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs3[2].transform.position = isGOPositions3[2].transform.position;

        #endregion

        #region Random4
        for (int positionInArray = 0; positionInArray < isGOPositions4.Length; positionInArray++) {

            GameObject obj = isGOPositions4[positionInArray];
            int randomArray = Random.Range(0, isGOPositions4.Length);
            isGOPositions4[positionInArray] = isGOPositions4[randomArray];
            isGOPositions4[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs4.Length; positionInArray++) {

            GameObject obj = isPrefabs4[positionInArray];
            int randomArray = Random.Range(0, isPrefabs4.Length);
            isPrefabs4[positionInArray] = isPrefabs4[randomArray];
            isPrefabs4[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs4[0].transform.position = isGOPositions4[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs4[1].transform.position = isGOPositions4[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs4[2].transform.position = isGOPositions4[2].transform.position;

        #endregion

        #region Random5
        for (int positionInArray = 0; positionInArray < isGOPositions5.Length; positionInArray++) {

            GameObject obj = isGOPositions5[positionInArray];
            int randomArray = Random.Range(0, isGOPositions5.Length);
            isGOPositions5[positionInArray] = isGOPositions5[randomArray];
            isGOPositions5[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs5.Length; positionInArray++) {

            GameObject obj = isPrefabs5[positionInArray];
            int randomArray = Random.Range(0, isPrefabs5.Length);
            isPrefabs5[positionInArray] = isPrefabs5[randomArray];
            isPrefabs5[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs5[0].transform.position = isGOPositions5[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs5[1].transform.position = isGOPositions5[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs5[2].transform.position = isGOPositions5[2].transform.position;

        #endregion

        #region Random6
        for (int positionInArray = 0; positionInArray < isGOPositions6.Length; positionInArray++) {

            GameObject obj = isGOPositions6[positionInArray];
            int randomArray = Random.Range(0, isGOPositions6.Length);
            isGOPositions6[positionInArray] = isGOPositions6[randomArray];
            isGOPositions6[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs6.Length; positionInArray++) {

            GameObject obj = isPrefabs6[positionInArray];
            int randomArray = Random.Range(0, isPrefabs6.Length);
            isPrefabs6[positionInArray] = isPrefabs6[randomArray];
            isPrefabs6[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs6[0].transform.position = isGOPositions6[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs6[1].transform.position = isGOPositions6[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs6[2].transform.position = isGOPositions6[2].transform.position;

        #endregion

        #region Random7
        for (int positionInArray = 0; positionInArray < isGOPositions7.Length; positionInArray++) {

            GameObject obj = isGOPositions7[positionInArray];
            int randomArray = Random.Range(0, isGOPositions7.Length);
            isGOPositions7[positionInArray] = isGOPositions7[randomArray];
            isGOPositions7[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs7.Length; positionInArray++) {

            GameObject obj = isPrefabs7[positionInArray];
            int randomArray = Random.Range(0, isPrefabs7.Length);
            isPrefabs7[positionInArray] = isPrefabs7[randomArray];
            isPrefabs7[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs7[0].transform.position = isGOPositions7[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs7[1].transform.position = isGOPositions7[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs7[2].transform.position = isGOPositions7[2].transform.position;

        #endregion

        #region Random8
        for (int positionInArray = 0; positionInArray < isGOPositions8.Length; positionInArray++) {

            GameObject obj = isGOPositions8[positionInArray];
            int randomArray = Random.Range(0, isGOPositions8.Length);
            isGOPositions8[positionInArray] = isGOPositions8[randomArray];
            isGOPositions8[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs8.Length; positionInArray++) {

            GameObject obj = isPrefabs8[positionInArray];
            int randomArray = Random.Range(0, isPrefabs8.Length);
            isPrefabs8[positionInArray] = isPrefabs8[randomArray];
            isPrefabs8[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs8[0].transform.position = isGOPositions8[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs8[1].transform.position = isGOPositions8[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs8[2].transform.position = isGOPositions8[2].transform.position;

        #endregion

        #region Random9
        for (int positionInArray = 0; positionInArray < isGOPositions9.Length; positionInArray++) {

            GameObject obj = isGOPositions9[positionInArray];
            int randomArray = Random.Range(0, isGOPositions9.Length);
            isGOPositions9[positionInArray] = isGOPositions9[randomArray];
            isGOPositions9[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs9.Length; positionInArray++) {

            GameObject obj = isPrefabs9[positionInArray];
            int randomArray = Random.Range(0, isPrefabs9.Length);
            isPrefabs9[positionInArray] = isPrefabs9[randomArray];
            isPrefabs9[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs9[0].transform.position = isGOPositions9[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs9[1].transform.position = isGOPositions9[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs9[2].transform.position = isGOPositions9[2].transform.position;

        #endregion

        #region Random10
        for (int positionInArray = 0; positionInArray < isGOPositions10.Length; positionInArray++) {

            GameObject obj = isGOPositions10[positionInArray];
            int randomArray = Random.Range(0, isGOPositions10.Length);
            isGOPositions10[positionInArray] = isGOPositions10[randomArray];
            isGOPositions10[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs10.Length; positionInArray++) {

            GameObject obj = isPrefabs10[positionInArray];
            int randomArray = Random.Range(0, isPrefabs10.Length);
            isPrefabs10[positionInArray] = isPrefabs10[randomArray];
            isPrefabs10[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs10[0].transform.position = isGOPositions10[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs10[1].transform.position = isGOPositions10[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs10[2].transform.position = isGOPositions10[2].transform.position;

        #endregion

        #region Random11
        for (int positionInArray = 0; positionInArray < isGOPositions11.Length; positionInArray++) {

            GameObject obj = isGOPositions11[positionInArray];
            int randomArray = Random.Range(0, isGOPositions11.Length);
            isGOPositions11[positionInArray] = isGOPositions11[randomArray];
            isGOPositions11[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs11.Length; positionInArray++) {

            GameObject obj = isPrefabs11[positionInArray];
            int randomArray = Random.Range(0, isPrefabs11.Length);
            isPrefabs11[positionInArray] = isPrefabs11[randomArray];
            isPrefabs11[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs11[0].transform.position = isGOPositions11[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs11[1].transform.position = isGOPositions11[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs11[2].transform.position = isGOPositions11[2].transform.position;

        #endregion

        #region Random12
        for (int positionInArray = 0; positionInArray < isGOPositions12.Length; positionInArray++) {

            GameObject obj = isGOPositions12[positionInArray];
            int randomArray = Random.Range(0, isGOPositions12.Length);
            isGOPositions12[positionInArray] = isGOPositions12[randomArray];
            isGOPositions12[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs12.Length; positionInArray++) {

            GameObject obj = isPrefabs12[positionInArray];
            int randomArray = Random.Range(0, isPrefabs12.Length);
            isPrefabs12[positionInArray] = isPrefabs12[randomArray];
            isPrefabs12[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs12[0].transform.position = isGOPositions12[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs12[1].transform.position = isGOPositions12[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs12[2].transform.position = isGOPositions12[2].transform.position;

        #endregion

        #region Random13
        for (int positionInArray = 0; positionInArray < isGOPositions13.Length; positionInArray++) {

            GameObject obj = isGOPositions13[positionInArray];
            int randomArray = Random.Range(0, isGOPositions13.Length);
            isGOPositions13[positionInArray] = isGOPositions13[randomArray];
            isGOPositions13[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs13.Length; positionInArray++) {

            GameObject obj = isPrefabs13[positionInArray];
            int randomArray = Random.Range(0, isPrefabs13.Length);
            isPrefabs13[positionInArray] = isPrefabs13[randomArray];
            isPrefabs13[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs13[0].transform.position = isGOPositions13[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs13[1].transform.position = isGOPositions13[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs13[2].transform.position = isGOPositions13[2].transform.position;

        #endregion

        #region Random14
        for (int positionInArray = 0; positionInArray < isGOPositions14.Length; positionInArray++) {

            GameObject obj = isGOPositions14[positionInArray];
            int randomArray = Random.Range(0, isGOPositions14.Length);
            isGOPositions14[positionInArray] = isGOPositions14[randomArray];
            isGOPositions14[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs14.Length; positionInArray++) {

            GameObject obj = isPrefabs14[positionInArray];
            int randomArray = Random.Range(0, isPrefabs14.Length);
            isPrefabs14[positionInArray] = isPrefabs14[randomArray];
            isPrefabs14[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs14[0].transform.position = isGOPositions14[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs14[1].transform.position = isGOPositions14[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs14[2].transform.position = isGOPositions14[2].transform.position;

        #endregion

        #region Random15
        for (int positionInArray = 0; positionInArray < isGOPositions15.Length; positionInArray++) {

            GameObject obj = isGOPositions15[positionInArray];
            int randomArray = Random.Range(0, isGOPositions15.Length);
            isGOPositions15[positionInArray] = isGOPositions15[randomArray];
            isGOPositions15[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs15.Length; positionInArray++) {

            GameObject obj = isPrefabs15[positionInArray];
            int randomArray = Random.Range(0, isPrefabs15.Length);
            isPrefabs15[positionInArray] = isPrefabs15[randomArray];
            isPrefabs15[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs15[0].transform.position = isGOPositions15[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs15[1].transform.position = isGOPositions15[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs15[2].transform.position = isGOPositions15[2].transform.position;

        #endregion

        #region Random16
        for (int positionInArray = 0; positionInArray < isGOPositions16.Length; positionInArray++) {

            GameObject obj = isGOPositions16[positionInArray];
            int randomArray = Random.Range(0, isGOPositions16.Length);
            isGOPositions16[positionInArray] = isGOPositions16[randomArray];
            isGOPositions16[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs16.Length; positionInArray++) {

            GameObject obj = isPrefabs16[positionInArray];
            int randomArray = Random.Range(0, isPrefabs16.Length);
            isPrefabs16[positionInArray] = isPrefabs16[randomArray];
            isPrefabs16[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs16[0].transform.position = isGOPositions16[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs16[1].transform.position = isGOPositions16[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs16[2].transform.position = isGOPositions16[2].transform.position;

        #endregion

        #region Random17
        for (int positionInArray = 0; positionInArray < isGOPositions17.Length; positionInArray++) {

            GameObject obj = isGOPositions17[positionInArray];
            int randomArray = Random.Range(0, isGOPositions17.Length);
            isGOPositions17[positionInArray] = isGOPositions17[randomArray];
            isGOPositions17[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs17.Length; positionInArray++) {

            GameObject obj = isPrefabs17[positionInArray];
            int randomArray = Random.Range(0, isPrefabs17.Length);
            isPrefabs17[positionInArray] = isPrefabs17[randomArray];
            isPrefabs17[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs17[0].transform.position = isGOPositions17[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs17[1].transform.position = isGOPositions17[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs17[2].transform.position = isGOPositions17[2].transform.position;

        #endregion

        #region Random18
        for (int positionInArray = 0; positionInArray < isGOPositions18.Length; positionInArray++) {

            GameObject obj = isGOPositions18[positionInArray];
            int randomArray = Random.Range(0, isGOPositions18.Length);
            isGOPositions18[positionInArray] = isGOPositions18[randomArray];
            isGOPositions18[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs18.Length; positionInArray++) {

            GameObject obj = isPrefabs18[positionInArray];
            int randomArray = Random.Range(0, isPrefabs18.Length);
            isPrefabs18[positionInArray] = isPrefabs18[randomArray];
            isPrefabs18[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs18[0].transform.position = isGOPositions18[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs18[1].transform.position = isGOPositions18[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs18[2].transform.position = isGOPositions18[2].transform.position;

        #endregion

        #region Random19
        for (int positionInArray = 0; positionInArray < isGOPositions19.Length; positionInArray++) {

            GameObject obj = isGOPositions19[positionInArray];
            int randomArray = Random.Range(0, isGOPositions19.Length);
            isGOPositions19[positionInArray] = isGOPositions19[randomArray];
            isGOPositions19[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs19.Length; positionInArray++) {

            GameObject obj = isPrefabs19[positionInArray];
            int randomArray = Random.Range(0, isPrefabs19.Length);
            isPrefabs19[positionInArray] = isPrefabs19[randomArray];
            isPrefabs19[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs19[0].transform.position = isGOPositions19[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs19[1].transform.position = isGOPositions19[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs19[2].transform.position = isGOPositions19[2].transform.position;

        #endregion

        #region Random20
        for (int positionInArray = 0; positionInArray < isGOPositions20.Length; positionInArray++) {

            GameObject obj = isGOPositions20[positionInArray];
            int randomArray = Random.Range(0, isGOPositions20.Length);
            isGOPositions20[positionInArray] = isGOPositions20[randomArray];
            isGOPositions20[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs20.Length; positionInArray++) {

            GameObject obj = isPrefabs20[positionInArray];
            int randomArray = Random.Range(0, isPrefabs20.Length);
            isPrefabs20[positionInArray] = isPrefabs20[randomArray];
            isPrefabs20[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs20[0].transform.position = isGOPositions20[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs20[1].transform.position = isGOPositions20[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs20[2].transform.position = isGOPositions20[2].transform.position;

        #endregion

        #region Random21
        for (int positionInArray = 0; positionInArray < isGOPositions21.Length; positionInArray++) {

            GameObject obj = isGOPositions21[positionInArray];
            int randomArray = Random.Range(0, isGOPositions21.Length);
            isGOPositions21[positionInArray] = isGOPositions21[randomArray];
            isGOPositions21[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs21.Length; positionInArray++) {

            GameObject obj = isPrefabs21[positionInArray];
            int randomArray = Random.Range(0, isPrefabs21.Length);
            isPrefabs21[positionInArray] = isPrefabs21[randomArray];
            isPrefabs21[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs21[0].transform.position = isGOPositions21[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs21[1].transform.position = isGOPositions21[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs21[2].transform.position = isGOPositions21[2].transform.position;

        #endregion

        #region Random22
        for (int positionInArray = 0; positionInArray < isGOPositions22.Length; positionInArray++) {

            GameObject obj = isGOPositions22[positionInArray];
            int randomArray = Random.Range(0, isGOPositions22.Length);
            isGOPositions22[positionInArray] = isGOPositions22[randomArray];
            isGOPositions22[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs22.Length; positionInArray++) {

            GameObject obj = isPrefabs22[positionInArray];
            int randomArray = Random.Range(0, isPrefabs22.Length);
            isPrefabs22[positionInArray] = isPrefabs22[randomArray];
            isPrefabs22[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs22[0].transform.position = isGOPositions22[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs22[1].transform.position = isGOPositions22[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs22[2].transform.position = isGOPositions22[2].transform.position;

        #endregion

        #region Random23
        for (int positionInArray = 0; positionInArray < isGOPositions23.Length; positionInArray++) {

            GameObject obj = isGOPositions23[positionInArray];
            int randomArray = Random.Range(0, isGOPositions23.Length);
            isGOPositions23[positionInArray] = isGOPositions23[randomArray];
            isGOPositions23[randomArray] = obj;

        }

        for (int positionInArray = 0; positionInArray < isPrefabs23.Length; positionInArray++) {

            GameObject obj = isPrefabs23[positionInArray];
            int randomArray = Random.Range(0, isPrefabs23.Length);
            isPrefabs23[positionInArray] = isPrefabs23[randomArray];
            isPrefabs23[randomArray] = obj;

        }

        //isPrefabs[0].transform.parent = isGOPrefabsPositions[0].transform;
        isPrefabs23[0].transform.position = isGOPositions23[0].transform.position;

        //isPrefabs[1].transform.parent = isGOPrefabsPositions[1].transform;
        isPrefabs23[1].transform.position = isGOPositions23[1].transform.position;

        //isPrefabs[2].transform.parent = isGOPrefabsPositions[2].transform;
        isPrefabs23[2].transform.position = isGOPositions23[2].transform.position;

        #endregion









        //isGOPrefabsPositions[3].transform.position = isPrefabs[3].transform.position;

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

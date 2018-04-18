using UnityEngine;
using System.Collections;

public class CoinsMaker : MonoBehaviour {

    public ObjectsPooler coinPool;
    public float maxPos = 1.18f;
    public bool BonusCoins;
    public bool TimeIsCome;
    GameObject [] Coins;

    private float timeCoin;
    private float CoinONTimeOff;
    public bool coinOn = false;
    private float timeWAIT;

    void Start()
    {
        Coins = new GameObject[27];
        timeCoin = 30f;
    }
    void Update()
    {
        timeCoin -= Time.deltaTime;
        if (Random.Range(0f, 85f) < 35 && timeCoin <= 0)
        {
            coinOn = true;
            SpawnCoins(new Vector3(26.5f, Random.Range(0.5f, 1.4f), 0.0f));
            timeCoin = Random.Range(30f, 35f);
            timeWAIT = 6.45f; 
        }
        if(coinOn)
        {
            timeWAIT -= Time.deltaTime;
            if (timeWAIT <= 0)
            {
                coinOn = false;
            }
        }


    }
    public void SpawnCoins(Vector3 startPostition)
    {
        int ran = Random.Range(1, 4);
        if (!BonusCoins)
        {
            if (ran == 1)
            {
                Coins[0] = coinPool.GetPooledObjects();
                Coins[0].transform.position = startPostition;
                Coins[0].SetActive(true);

                Coins[1] = coinPool.GetPooledObjects();
                Coins[1].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y - 0.2f, startPostition.z);
                Coins[1].SetActive(true);

                Coins[2] = coinPool.GetPooledObjects();
                Coins[2].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y - 0.4f, startPostition.z);
                Coins[2].SetActive(true);

                Coins[3] = coinPool.GetPooledObjects();
                Coins[3].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y - 0.55f, startPostition.z);
                Coins[3].SetActive(true);

                Coins[4] = coinPool.GetPooledObjects();
                Coins[4].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y - 0.5f, startPostition.z);
                Coins[4].SetActive(true);

                Coins[5] = coinPool.GetPooledObjects();
                Coins[5].transform.position = new Vector3(startPostition.x - 2f, startPostition.y - 0.4f, startPostition.z);
                Coins[5].SetActive(true);

                Coins[6] = coinPool.GetPooledObjects();
                Coins[6].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y - 0.2f, startPostition.z);
                Coins[6].SetActive(true);

                Coins[7] = coinPool.GetPooledObjects();
                Coins[7].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y + 0.2f, startPostition.z);
                Coins[7].SetActive(true);

                Coins[8] = coinPool.GetPooledObjects();
                Coins[8].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y + 0.4f, startPostition.z);
                Coins[8].SetActive(true);

                Coins[9] = coinPool.GetPooledObjects();
                Coins[9].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y + 0.55f, startPostition.z);
                Coins[9].SetActive(true);

                Coins[10] = coinPool.GetPooledObjects();
                Coins[10].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y + 0.5f, startPostition.z);
                Coins[10].SetActive(true);

                Coins[11] = coinPool.GetPooledObjects();
                Coins[11].transform.position = new Vector3(startPostition.x + 2f, startPostition.y + 0.4f, startPostition.z);
                Coins[11].SetActive(true);

                Coins[12] = coinPool.GetPooledObjects();
                Coins[12].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y + 0.2f, startPostition.z);
                Coins[12].SetActive(true);

                //////////////////////////

                Coins[13] = coinPool.GetPooledObjects();
                Coins[13].transform.position = new Vector3(startPostition.x, startPostition.y + 0.6f, startPostition.z);
                Coins[13].SetActive(true);

                Coins[14] = coinPool.GetPooledObjects();
                Coins[14].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y - 0.2f + 0.6f, startPostition.z);
                Coins[14].SetActive(true);

                Coins[15] = coinPool.GetPooledObjects();
                Coins[15].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y - 0.4f + 0.6f, startPostition.z);
                Coins[15].SetActive(true);

                Coins[16] = coinPool.GetPooledObjects();
                Coins[16].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y - 0.55f + 0.6f, startPostition.z);
                Coins[16].SetActive(true);

                Coins[17] = coinPool.GetPooledObjects();
                Coins[17].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y - 0.5f + 0.6f, startPostition.z);
                Coins[17].SetActive(true);

                Coins[18] = coinPool.GetPooledObjects();
                Coins[18].transform.position = new Vector3(startPostition.x - 2f, startPostition.y - 0.4f + 0.6f, startPostition.z);
                Coins[18].SetActive(true);

                Coins[19] = coinPool.GetPooledObjects();
                Coins[19].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y - 0.2f + 0.6f, startPostition.z);
                Coins[19].SetActive(true);

                Coins[20] = coinPool.GetPooledObjects();
                Coins[20].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y + 0.2f + 0.6f, startPostition.z);
                Coins[20].SetActive(true);

                Coins[21] = coinPool.GetPooledObjects();
                Coins[21].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y + 0.4f + 0.6f, startPostition.z);
                Coins[21].SetActive(true);

                Coins[22] = coinPool.GetPooledObjects();
                Coins[22].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y + 0.55f + 0.6f, startPostition.z);
                Coins[22].SetActive(true);

                Coins[23] = coinPool.GetPooledObjects();
                Coins[23].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y + 0.5f + 0.6f, startPostition.z);
                Coins[23].SetActive(true);

                Coins[24] = coinPool.GetPooledObjects();
                Coins[24].transform.position = new Vector3(startPostition.x + 2f, startPostition.y + 0.4f + 0.6f, startPostition.z);
                Coins[24].SetActive(true);

                Coins[25] = coinPool.GetPooledObjects();
                Coins[25].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y + 0.2f + 0.6f, startPostition.z);
                Coins[25].SetActive(true);
            }
            else if (ran == 2)
            {
                Coins[1] = coinPool.GetPooledObjects();
                Coins[1].transform.position = startPostition;
                Coins[1].SetActive(true);

                Coins[2] = coinPool.GetPooledObjects();
                Coins[2].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y, startPostition.z);
                Coins[2].SetActive(true);

                Coins[3] = coinPool.GetPooledObjects();
                Coins[3].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y, startPostition.z);
                Coins[3].SetActive(true);

                Coins[4] = coinPool.GetPooledObjects();
                Coins[4].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y , startPostition.z);
                Coins[4].SetActive(true);

                Coins[5] = coinPool.GetPooledObjects();
                Coins[5].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y, startPostition.z);
                Coins[5].SetActive(true);

                Coins[6] = coinPool.GetPooledObjects();
                Coins[6].transform.position = new Vector3(startPostition.x - 2f, startPostition.y, startPostition.z);
                Coins[6].SetActive(true);

                Coins[7] = coinPool.GetPooledObjects();
                Coins[7].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y, startPostition.z);
                Coins[7].SetActive(true);

                Coins[8] = coinPool.GetPooledObjects();
                Coins[8].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y, startPostition.z);
                Coins[8].SetActive(true);

                Coins[9] = coinPool.GetPooledObjects();
                Coins[9].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y, startPostition.z);
                Coins[9].SetActive(true);

                Coins[10] = coinPool.GetPooledObjects();
                Coins[10].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y, startPostition.z);
                Coins[10].SetActive(true);

                Coins[11] = coinPool.GetPooledObjects();
                Coins[11].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y, startPostition.z);
                Coins[11].SetActive(true);

                Coins[12] = coinPool.GetPooledObjects();
                Coins[12].transform.position = new Vector3(startPostition.x + 2f, startPostition.y, startPostition.z);
                Coins[12].SetActive(true);

                Coins[13] = coinPool.GetPooledObjects();
                Coins[13].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y, startPostition.z);
                Coins[13].SetActive(true);

                //////////////////////////////////

                Coins[14] = coinPool.GetPooledObjects();
                Coins[14].transform.position = new Vector3(startPostition.x , startPostition.y - 0.6f, startPostition.z);
                Coins[14].SetActive(true);

                Coins[15] = coinPool.GetPooledObjects();
                Coins[15].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y -0.6f, startPostition.z);
                Coins[15].SetActive(true);

                Coins[16] = coinPool.GetPooledObjects();
                Coins[16].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y - 0.6f, startPostition.z);
                Coins[16].SetActive(true);

                Coins[17] = coinPool.GetPooledObjects();
                Coins[17].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y - 0.6f, startPostition.z);
                Coins[17].SetActive(true);

                Coins[18] = coinPool.GetPooledObjects();
                Coins[18].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y - 0.6f, startPostition.z);
                Coins[18].SetActive(true);

                Coins[19] = coinPool.GetPooledObjects();
                Coins[19].transform.position = new Vector3(startPostition.x - 2f, startPostition.y - 0.6f, startPostition.z);
                Coins[19].SetActive(true);

                Coins[20] = coinPool.GetPooledObjects();
                Coins[20].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y - 0.6f, startPostition.z);
                Coins[20].SetActive(true);

                Coins[21] = coinPool.GetPooledObjects();
                Coins[21].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 0.6f, startPostition.z);
                Coins[21].SetActive(true);

                Coins[22] = coinPool.GetPooledObjects();
                Coins[22].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y - 0.6f, startPostition.z);
                Coins[22].SetActive(true);

                Coins[23] = coinPool.GetPooledObjects();
                Coins[23].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y - 0.6f, startPostition.z);
                Coins[23].SetActive(true);

                Coins[24] = coinPool.GetPooledObjects();
                Coins[24].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y - 0.6f, startPostition.z);
                Coins[24].SetActive(true);

                Coins[25] = coinPool.GetPooledObjects();
                Coins[25].transform.position = new Vector3(startPostition.x + 2f, startPostition.y - 0.6f, startPostition.z);
                Coins[25].SetActive(true);

                Coins[26] = coinPool.GetPooledObjects();
                Coins[26].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y - 0.6f, startPostition.z);
                Coins[26].SetActive(true);
            }
            else if (ran == 3)
            {
                Coins[1] = coinPool.GetPooledObjects();
                Coins[1].transform.position = startPostition;
                Coins[1].SetActive(true);

                Coins[2] = coinPool.GetPooledObjects();
                Coins[2].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y + 0.2f, startPostition.z);
                Coins[2].SetActive(true);

                Coins[3] = coinPool.GetPooledObjects();
                Coins[3].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y + 0.4f, startPostition.z);
                Coins[3].SetActive(true);

                Coins[4] = coinPool.GetPooledObjects();
                Coins[4].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y + 0.55f, startPostition.z);
                Coins[4].SetActive(true);

                Coins[5] = coinPool.GetPooledObjects();
                Coins[5].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y + 0.5f, startPostition.z);
                Coins[5].SetActive(true);

                Coins[6] = coinPool.GetPooledObjects();
                Coins[6].transform.position = new Vector3(startPostition.x - 2f, startPostition.y + 0.4f, startPostition.z);
                Coins[6].SetActive(true);

                Coins[7] = coinPool.GetPooledObjects();
                Coins[7].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y + 0.2f, startPostition.z);
                Coins[7].SetActive(true);

                Coins[8] = coinPool.GetPooledObjects();
                Coins[8].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 0.2f, startPostition.z);
                Coins[8].SetActive(true);

                Coins[9] = coinPool.GetPooledObjects();
                Coins[9].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y - 0.4f, startPostition.z);
                Coins[9].SetActive(true);

                Coins[10] = coinPool.GetPooledObjects();
                Coins[10].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y - 0.55f, startPostition.z);
                Coins[10].SetActive(true);

                Coins[11] = coinPool.GetPooledObjects();
                Coins[11].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y - 0.5f, startPostition.z);
                Coins[11].SetActive(true);

                Coins[12] = coinPool.GetPooledObjects();
                Coins[12].transform.position = new Vector3(startPostition.x + 2f, startPostition.y - 0.4f, startPostition.z);
                Coins[12].SetActive(true);

                Coins[13] = coinPool.GetPooledObjects();
                Coins[13].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y - 0.2f, startPostition.z);
                Coins[13].SetActive(true);


                /////////////////////////////

                Coins[14] = coinPool.GetPooledObjects();
                Coins[14].transform.position = new Vector3(startPostition.x , startPostition.y -0.6f, startPostition.z);
                Coins[14].SetActive(true);

                Coins[15] = coinPool.GetPooledObjects();
                Coins[15].transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y + 0.2f - 0.6f, startPostition.z);
                Coins[15].SetActive(true);

                Coins[16] = coinPool.GetPooledObjects();
                Coins[16].transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y + 0.4f - 0.6f, startPostition.z);
                Coins[16].SetActive(true);

                Coins[17] = coinPool.GetPooledObjects();
                Coins[17].transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y + 0.55f - 0.6f, startPostition.z);
                Coins[17].SetActive(true);

                Coins[18] = coinPool.GetPooledObjects();
                Coins[18].transform.position = new Vector3(startPostition.x - 1.6f, startPostition.y + 0.5f - 0.6f, startPostition.z);
                Coins[18].SetActive(true);

                Coins[19] = coinPool.GetPooledObjects();
                Coins[19].transform.position = new Vector3(startPostition.x - 2f, startPostition.y + 0.4f - 0.6f, startPostition.z);
                Coins[19].SetActive(true);

                Coins[20] = coinPool.GetPooledObjects();
                Coins[20].transform.position = new Vector3(startPostition.x - 2.4f, startPostition.y + 0.2f - 0.6f, startPostition.z);
                Coins[20].SetActive(true);

                Coins[21] = coinPool.GetPooledObjects();
                Coins[21].transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 0.2f - 0.6f, startPostition.z);
                Coins[21].SetActive(true);

                Coins[22] = coinPool.GetPooledObjects();
                Coins[22].transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y - 0.4f - 0.6f, startPostition.z);
                Coins[22].SetActive(true);

                Coins[23] = coinPool.GetPooledObjects();
                Coins[23].transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y - 0.55f - 0.6f, startPostition.z);
                Coins[23].SetActive(true);

                Coins[24] = coinPool.GetPooledObjects();
                Coins[24].transform.position = new Vector3(startPostition.x + 1.6f, startPostition.y - 0.5f - 0.6f, startPostition.z);
                Coins[24].SetActive(true);

                Coins[25] = coinPool.GetPooledObjects();
                Coins[25].transform.position = new Vector3(startPostition.x + 2f, startPostition.y - 0.4f - 0.6f, startPostition.z);
                Coins[25].SetActive(true);

                Coins[26] = coinPool.GetPooledObjects();
                Coins[26].transform.position = new Vector3(startPostition.x + 2.4f, startPostition.y - 0.2f - 0.6f, startPostition.z);
                Coins[26].SetActive(true);
            }
        }
        /*
        if (BonusCoins)
        {
            GameObject coin1 = coinPool.GetPooledObjects();
            coin1.transform.position = startPostition;
            coin1.SetActive(true);

            GameObject coin2 = coinPool.GetPooledObjects();
            coin2.transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y, startPostition.z);
            coin2.SetActive(true);

            GameObject coin3 = coinPool.GetPooledObjects();
            coin3.transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y, startPostition.z);
            coin3.SetActive(true);

            GameObject coin4 = coinPool.GetPooledObjects();
            coin4.transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y - 0.4f, startPostition.z);
            coin4.SetActive(true);

            GameObject coin5 = coinPool.GetPooledObjects();
            coin5.transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 0.4f, startPostition.z);
            coin5.SetActive(true);

            GameObject Coins[4] = coinPool.GetPooledObjects();
            Coins[4].transform.position = new Vector3(startPostition.x, startPostition.y - 0.4f, startPostition.z);
            Coins[4].SetActive(true);

            GameObject coin7 = coinPool.GetPooledObjects();
            coin7.transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y - 0.8f, startPostition.z);
            coin7.SetActive(true);

            GameObject coin8 = coinPool.GetPooledObjects();
            coin8.transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 0.8f, startPostition.z);
            coin8.SetActive(true);

            GameObject coin9 = coinPool.GetPooledObjects();
            coin9.transform.position = new Vector3(startPostition.x, startPostition.y - 0.8f, startPostition.z);
            coin9.SetActive(true);

            ////////////////
            GameObject coin10 = coinPool.GetPooledObjects();
            coin10.transform.position = new Vector3(startPostition.x - 0.4f, startPostition.y - 1.2f, startPostition.z);
            coin10.SetActive(true);

            GameObject coin11 = coinPool.GetPooledObjects();
            coin11.transform.position = new Vector3(startPostition.x + 0.4f, startPostition.y - 1.2f, startPostition.z);
            coin11.SetActive(true);

            GameObject coin12 = coinPool.GetPooledObjects();
            coin12.transform.position = new Vector3(startPostition.x, startPostition.y - 1.2f, startPostition.z);
            coin12.SetActive(true);

            GameObject coin13 = coinPool.GetPooledObjects();
            coin13.transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y - 0.4f, startPostition.z);
            coin13.SetActive(true);

            GameObject coin14 = coinPool.GetPooledObjects();
            coin14.transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y - 0.4f, startPostition.z);
            coin14.SetActive(true);

            GameObject coin15 = coinPool.GetPooledObjects();
            coin15.transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y - 0.4f, startPostition.z);
            coin15.SetActive(true);

            GameObject coin16 = coinPool.GetPooledObjects();
            coin16.transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y - 0.4f, startPostition.z);
            coin16.SetActive(true);

            GameObject coin17 = coinPool.GetPooledObjects();
            coin17.transform.position = new Vector3(startPostition.x - 0.8f, startPostition.y - 0.8f, startPostition.z);
            coin17.SetActive(true);

            GameObject coin18 = coinPool.GetPooledObjects();
            coin18.transform.position = new Vector3(startPostition.x + 0.8f, startPostition.y - 0.8f, startPostition.z);
            coin18.SetActive(true);

            GameObject coin19 = coinPool.GetPooledObjects();
            coin19.transform.position = new Vector3(startPostition.x - 1.2f, startPostition.y - 0.8f, startPostition.z);
            coin19.SetActive(true);

            GameObject coin20 = coinPool.GetPooledObjects();
            coin20.transform.position = new Vector3(startPostition.x + 1.2f, startPostition.y - 0.8f, startPostition.z);
            coin20.SetActive(true);
            //////////////////////////////////
        }
        */

    }
}


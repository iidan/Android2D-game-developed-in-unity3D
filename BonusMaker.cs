using UnityEngine;
using System.Collections;

public class BonusMaker : MonoBehaviour {

    private float time = 23;
    private double[] arr = { -1.40, -0.762, 0.047, 0.771, 1.38 };
    public ObjectsPooler BonusPool;
    public bool BonusON;
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        int Save = Random.Range(0, (arr.Length));

        if (time <= 0 && Random.Range(0, 53) == 31)
        {
            BonusON = true;

            GameObject newBonus = BonusPool.GetPooledObjects();
            newBonus.transform.position = transform.position + new Vector3((float)arr[Save], 0f, -0.005f);
            newBonus.SetActive(true);
            time = Random.Range(11.1f, 17.8f);

        }
        BonusON = false;
    }
}

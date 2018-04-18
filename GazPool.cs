using UnityEngine;
using System.Collections;

public class GazPool : MonoBehaviour {

    private float time = 20;
    private double[] arr = { -1.40, -0.762, 0.047, 0.771, 1.38 };
    public ObjectsPooler GazPooled;
    public bool GazON;

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        int Save = Random.Range(0, (arr.Length));

        if (time <= 0 && Random.Range(0, 42) == 27)
        {
            GazON = true;

            GameObject newBonus = GazPooled.GetPooledObjects();
            newBonus.transform.position = transform.position + new Vector3((float)arr[Save], 0f, -0.005f);
            newBonus.SetActive(true);
            time = Random.Range(7.1f, 12.9f);

        }
        GazON = false;
    }
}

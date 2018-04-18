using UnityEngine;
using System.Collections;

public class SignPool : MonoBehaviour
{
    public ObjectsPooler[] theObjectPools;
    public int CountSign;
    public int CountArrowSign;
    public int tempNumber;

    void Start()
    {
        CountSign = PlayerPrefs.GetInt("signCounter");
        CountArrowSign = PlayerPrefs.GetInt("CountArrowSign");
    }

    public void SpwanSign(Vector3 startPostition)
    {
        tempNumber = Random.Range(0, theObjectPools.Length);
        GameObject sign = theObjectPools[tempNumber].GetPooledObjects();
        sign.transform.position = new Vector3(startPostition.x, -1.861f, 0f);
        sign.SetActive(true);
    }

    public void CounterSigns()
    {
        CountSign++;
        PlayerPrefs.SetInt("signCounter", CountSign);
    }
    public void CounterArrowSigns()
    {
        CountArrowSign++;
        PlayerPrefs.SetInt("CountArrowSign", CountArrowSign);
    }
}

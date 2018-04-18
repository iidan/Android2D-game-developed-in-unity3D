using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectsPooler : MonoBehaviour {

    public GameObject pooledObject;

    public int pooledAmount;

    List<GameObject> pooledObjects;

    // Use this for initialization
    void Start()
    {
        pooledObjects = new List<GameObject>();

        for (int i = 0; i < pooledAmount; i++)
        {
            // create new game object (pool) , (for copy of the pool of my game).
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);

            // add to the list.
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObjects()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            // activeInHierarchy if this object active in the Scene.
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        // if not create again new object.

        GameObject obj = (GameObject)Instantiate(pooledObject);
        obj.SetActive(false);
        // add to the list.
        pooledObjects.Add(obj);

        return obj;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] groups;

    void Sart() 
    {
        spawnNext();
    }

    public void spawnNext()
    {
        // Random Index
        //int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        Instantiate(groups[Random.Range(0, groups.Length)], transform.position, Quaternion.identity);
    }
}

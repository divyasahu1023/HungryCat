using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject spawnpoint;
    [SerializeField] List<GameObject> prefabToSpawn;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Destroy");
            Destroy(other.gameObject);

            // Spawn

            int index = Random.Range(0, prefabToSpawn.Count - 1);
            GameObject spawn = prefabToSpawn[index];
            Instantiate(spawn, spawnpoint.transform.position,Quaternion.identity);
        }
    }
}
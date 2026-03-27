using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float minX = -2;
    public float maxX = 2;
    public GameObject itemToSpawn;

    public float timeBetweenSpawns = 1;
    private float timer;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenSpawns)
        {
            Vector3 nextPos = transform.position;
            nextPos.x = Random.Range(minX, maxX);
            Instantiate(itemToSpawn, nextPos, Quaternion.identity);
            timer = 0;
        }
    }
}

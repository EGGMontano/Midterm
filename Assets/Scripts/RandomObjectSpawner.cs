using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{
    [Header("Walls")]
    [SerializeField] GameObject largeWall;
    [SerializeField] GameObject mediumWall;
    [SerializeField] GameObject smallWall;

    [Header("Spawn Settings")]
    [SerializeField] float spawnChance = 5f;                //Default settings

    [Header("Raycast Settings")]
    [SerializeField] float distanceBetweenCheck = 0.5f;    //Default settings
    [SerializeField] float rangeOfCheck = 30f;              //Default settings
    [SerializeField] LayerMask layerMask;
    [SerializeField] Vector2 positivePosition, negativePosition;


    private void Start()
    {
        SpawnPrefabs();
    }

    private void Update()
    {
        DeletePrefab();
    }

    void SpawnPrefabs()
    {
        for (float x = negativePosition.x; x < positivePosition.x; x += distanceBetweenCheck)
        {
            for (float z = negativePosition.y; z < positivePosition.y; z += distanceBetweenCheck)
            {
                RaycastHit hit;
                if (Physics.Raycast(new Vector3(x, z), Vector3.down, out hit, rangeOfCheck, layerMask))
                {
                    if (spawnChance > Random.Range(0f, 101f))
                    {
                        Instantiate(largeWall, hit.point, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
                        Instantiate(mediumWall, hit.point, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
                        Instantiate(smallWall, hit.point, Quaternion.Euler(new Vector3(0, Random.Range(0, 360), 0)), transform);
                    }
                }
            }
        }
    }

    void DeletePrefab()
    {

    }
}

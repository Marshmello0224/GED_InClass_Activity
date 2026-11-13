using UnityEngine;

public class SquareSpawner : MonoBehaviour
{
    [SerializeField] Vector3 spawnPos = new Vector3(0f, 5f, 0f);
    public GameObject squarePrefab;
    public void FixedUpdate()
    {
     GameObject boxGO = Instantiate(squarePrefab, spawnPos, Quaternion.identity);
        Destroy(boxGO, 1.0f);
    }
}

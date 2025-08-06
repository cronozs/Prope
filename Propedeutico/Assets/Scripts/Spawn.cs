using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawners;
    void Start()
    {
        for(int i = 0; i<= spawners.Length; i++)
        {
            Instantiate(enemy, spawners[i]);
        }
    }
}

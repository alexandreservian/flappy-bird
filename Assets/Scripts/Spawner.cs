using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timeRepeat = 1f;
    [SerializeField] private float heightRange = 0.2f;
    [SerializeField] private GameObject pipe;
    void Start()
    {
        InvokeRepeating(nameof(Spawn), timeRepeat, timeRepeat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn () {
        Vector3 positionPipe = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        Instantiate(pipe, positionPipe, Quaternion.identity);
    }
}

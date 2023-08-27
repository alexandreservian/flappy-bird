using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float velocityMove = 1f;
    float boardLeft;
    void Start()
    {
        var mainCamera = Camera.main;
        boardLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0.5f, mainCamera.nearClipPlane)).x - 0.3f;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + -(velocityMove * Time.deltaTime), transform.position.y);

        if(transform.position.x <= boardLeft) {
            Destroy(gameObject);
        }
    }
}

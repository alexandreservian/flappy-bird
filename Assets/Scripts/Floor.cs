using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    SpriteRenderer spriteRenderer;
    Vector2 startPosition;
    float boardRight;
    float boardLeft;
    void Start()
    {
        var mainCamera = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
        boardRight = mainCamera.ViewportToWorldPoint(new Vector3(1, 0.5f, mainCamera.nearClipPlane)).x;
        boardLeft = mainCamera.ViewportToWorldPoint(new Vector3(0, 0.5f, mainCamera.nearClipPlane)).x;
        startPosition = new Vector2((spriteRenderer.size.x / 2) + boardLeft, transform.position.y);
        transform.position = startPosition;
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x + -(speed * Time.deltaTime), transform.position.y);
        if(spriteRenderer.bounds.max.x <= boardRight) {
            transform.position = startPosition;
        }
    }
}

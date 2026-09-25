using System;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] private float speed = 4f;
    private float startTime;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.time; 
        playerPosition = Player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();

    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed* Time.deltaTime);       
    }

    private void DestroyWhenReached()
    {
       if (transform.position == playerPosition) Destroy(gameObject);
    }

}

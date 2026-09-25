using UnityEngine;

public class WallCollider : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("HI");
        if (collision.gameObject.tag == "Cube")
        {
            Debug.Log("HI2");
            Mover cube = FindAnyObjectByType<Mover>();
            cube.ChangeDirection();
        }
    }
}

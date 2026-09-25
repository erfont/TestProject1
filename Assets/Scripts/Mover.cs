using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] [Range(0f, 1f)] float X;
    [SerializeField] [Range(0f, 1f)]float Y, Z;
    [SerializeField] private int direction;
    [SerializeField] [Range(0f, 5f)] float speed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direction = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(X * direction * speed * Time.deltaTime, Y * Time.deltaTime * speed, Z * Time.deltaTime * speed);
    }

    public void ChangeDirection()
    {
        this.direction *= -1;
    }
}

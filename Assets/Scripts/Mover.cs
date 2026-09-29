using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 directionVector;
    [SerializeField][Range(0f, 5f)] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        directionVector = new Vector3(1, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(directionVector.x * speed * Time.deltaTime, directionVector.y * speed * Time.deltaTime, directionVector.z * speed * Time.deltaTime);
    }

    public void ChangeDirection(Vector3 direction)
    {
        this.directionVector = direction;
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 direction = collision.GetContact(0).normal;
        Debug.Log(direction);

        if (collision.gameObject.tag == "Wall")
        {
            this.ChangeDirection(direction);
        }
    }
}

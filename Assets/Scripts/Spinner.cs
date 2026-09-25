using UnityEngine;

public class Spinner : MonoBehaviour
{
     [SerializeField] float xAngle = 0f, yAngle = 10f, zAngle = 0f;
    // float [SerializeField] yAngle;
    // float [SerializeField] zAngle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle* Time.deltaTime, yAngle* Time.deltaTime, zAngle* Time.deltaTime);
    }
}

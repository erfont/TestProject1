using UnityEngine;

public class Dropper : MonoBehaviour
{
    private float startTime;

    [SerializeField] [Range(0f, 3f)] float waitTime;
    Rigidbody myRigidBody;
    MeshRenderer myMeshRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startTime = Time.time;  
        myRigidBody = GetComponentInChildren<Rigidbody>();
        myMeshRenderer = GetComponentInChildren<MeshRenderer>();
        myRigidBody.useGravity = false;
        myMeshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: Time.time - startTime);
        if (Time.time - startTime > 3) 
        {
            myRigidBody.useGravity = true;
            myMeshRenderer.enabled = true;
        }
    }
}

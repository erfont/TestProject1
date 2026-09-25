using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;


public class PlayerInputController : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public bool jump;
    Rigidbody rb;
    public float ThrustForce = 2500;
    private float directionX, directionZ;
    [SerializeField] [Range(0f, 5f)] float speed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         rb = GetComponentInChildren<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (jump) 
        {
            Debug.Log("Jumping!");
            rb.AddRelativeForce(Vector3.up * ThrustForce * Time.fixedDeltaTime);
            StartCoroutine(WaitCoroutine(1f));
           
        }

        Move();
        
    }

    private void Move()
    {
        directionX = move.x;
        directionZ = move.y;

        transform.Translate(directionX * speed * Time.deltaTime, 0, directionZ * Time.deltaTime * speed);
    }

    IEnumerator WaitCoroutine(float seconds)
    {
       
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(seconds);
         jump = false;

        
    }

     public void OnMove(InputValue value)
    {
       move = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        jump = value.isPressed;
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInputController : MonoBehaviour
{
    [Header("Character Input Values")]
    public Vector2 move;
    public bool jump;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (jump) 
        {
            Debug.Log("Jumping!");
            StartCoroutine(WaitCoroutine(1));
            jump = false;
        }
        
    }

    IEnumerator WaitCoroutine(int seconds)
    {
       
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(seconds);

        
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

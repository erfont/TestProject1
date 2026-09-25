using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    int GroundLayerMask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // RaycastHit hit;
        // if (Physics.Raycast(Camera.main.transform.position, Input.mousePosition, out hit))
        // {
        //     transform.position = hit.point;
        // }


    }

    public void OnMove(InputValue value)
    {
        // GroundLayerMask = 1 << LayerMask.NameToLayer("Ground");
        // Debug.Log("Hi!");
        // Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        // if (Physics.Raycast(ray, out RaycastHit hit, 1000f, GroundLayerMask))
        // {
        //     Vector3 worldPosition = hit.point;
        //     // Use your 3D world position here
        //     transform.position = worldPosition;
        // }
    }

    public void OnGroundClick(InputValue value)
    {
        GroundLayerMask = 1 << LayerMask.NameToLayer("Ground");
        Debug.Log("Hi!");
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, 1000f, GroundLayerMask))
        {
            Vector3 worldPosition = hit.point;
            // Use your 3D world position here
            transform.position = worldPosition;
        }
    }




}

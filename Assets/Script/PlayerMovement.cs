using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody myRigidbody;
public float movementSpeed = 5.5f;

    // Update is called once per frame
    void Update()
    {
        myRigidbody.linearVelocity = Vector3.zero;

        if (Keyboard.current.aKey.isPressed)
        {
            myRigidbody.linearVelocity = Vector3.left * movementSpeed;
        }
        
        if (Keyboard.current.dKey.isPressed)
        {
            myRigidbody.linearVelocity = Vector3.right * movementSpeed;
        }
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class TouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public enum AxisDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    [Header("Ball Movement")]
    public Rigidbody ballRigidbody;
    public AxisDirection direction = AxisDirection.Up;
    public float moveForce = 10f;

    bool isPressed;

    Vector3 MoveDirection
    {
        get
        {
            return direction switch
            {
                AxisDirection.Up => Vector3.forward,
                AxisDirection.Down => Vector3.back,
                AxisDirection.Left => Vector3.left,
                AxisDirection.Right => Vector3.right,
                _ => Vector3.zero,
            };
        }
    }

    void FixedUpdate()
    {
        if (isPressed && ballRigidbody != null)
        {
            ballRigidbody.AddForce(MoveDirection * moveForce, ForceMode.Acceleration);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Release();
    }

    public void Press()
    {
        isPressed = true;
    }

    public void Release()
    {
        isPressed = false;
        if (ballRigidbody != null)
        {
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
        }
    }

    void OnValidate()
    {
        if (ballRigidbody == null)
        {
            Debug.LogWarning($"{name}: ballRigidbody is not assigned.", this);
        }
    }
}

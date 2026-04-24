using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 forwardDirection = Vector3.up;
    [SerializeField] private float rotationSpeed = 10f;
    
    private Rigidbody targetRigidbody;

    private void Start()
    {
        if (target != null)
        {
            targetRigidbody = target.GetComponent<Rigidbody>();
        }
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            // Follow position
            transform.position = target.position;

            // Rotate to face movement direction
            if (targetRigidbody != null && targetRigidbody.velocity.magnitude > 0.01f)
            {
                Vector3 velocity = targetRigidbody.velocity;
                Vector3 lookDirection = new Vector3(velocity.x, 0, velocity.z);
                
                Quaternion targetRotation = Quaternion.LookRotation(lookDirection, Vector3.up);
                Quaternion forwardRotation = Quaternion.FromToRotation(forwardDirection, Vector3.forward);
                
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation * forwardRotation, Time.deltaTime * rotationSpeed);
            }
        }
    }
}

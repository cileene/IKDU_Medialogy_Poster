using UnityEngine;

public class SmoothRotation : MonoBehaviour
{
    [Header("Target Settings")]
    public Vector3 targetPosition;  // Target position (optional use)
    public Vector3 targetRotation;  // Target rotation in Euler angles

    [Header("Rotation Settings")]
    public float rotationSpeed = 5f;  // Rotation speed

    private bool isRotating = false;  // Flag to indicate rotation

    void Update()
    {
        // If rotation is active, update rotation smoothly
        if (isRotating)
        {
            RotateTowardsTarget();
        }
    }

    // Method to start the rotation, can be called from the editor
    public void StartRotation()
    {
        isRotating = true;
    }

    // Smooth rotation logic
    private void RotateTowardsTarget()
    {
        // Get current rotation
        Quaternion currentRotation = transform.rotation;

        // Convert target Euler angles to Quaternion
        Quaternion targetQuaternion = Quaternion.Euler(targetRotation);

        // Smoothly interpolate between current and target rotation
        transform.rotation = Quaternion.Slerp(currentRotation, targetQuaternion, rotationSpeed * Time.deltaTime);

        // Check if the rotation is close enough to stop
        if (Quaternion.Angle(currentRotation, targetQuaternion) < 0.1f)
        {
            transform.rotation = targetQuaternion;
            isRotating = false;  // Stop rotating
        }
    }

    // Reset rotation manually
    public void StopRotation()
    {
        isRotating = false;
    }
}
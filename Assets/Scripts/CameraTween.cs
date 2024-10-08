using UnityEngine;

public class CameraTween : MonoBehaviour
{

    // When the camera receive the CLICK signal, it wil move to the target position
    public void MoveToTarget(Vector3 targetPosition)
    {
        // Move the camera to the target position
        transform.position = targetPosition;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

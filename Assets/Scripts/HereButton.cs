using UnityEngine;

public class HereButton : MonoBehaviour
{
    // Script to tween the buttons z rotation back an forth to show its clickable
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        // Tween the z rotation of the button
        transform.rotation = Quaternion.Euler(0, 0, 5 * Mathf.Sin(Time.time * 4));
        
    }
}

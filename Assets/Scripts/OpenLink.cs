using UnityEngine;

public class OpenLink : MonoBehaviour
{
    // Method that opens the web link
    public void OpenWebsite(string url)
    {
        Application.OpenURL(url); // Opens the given URL in the default browser
    }
}
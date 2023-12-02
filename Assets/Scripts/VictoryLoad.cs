using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryLoad : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    private void OnTriggerEnter(Collider other)
    {
        // Controleer of de speler de finishlijn raakt
        if (other.CompareTag("Player"))
        {
            // Controleer of de collider de tag "Finish" heeft
            if (gameObject.CompareTag("Finish"))
            {

                // Laad de VictoryScreen scene
                SceneManager.LoadScene("VictoryScreen");
            }
        }
    }
}

using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip footstepSound;
    public float stepInterval = 0.5f;
    private float stepTimer;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        stepTimer = stepInterval;
    }

    private void Update()
    {
        // Simpel voorbeeld - vervang met jouw bewegingslogica
        bool isMoving = Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;

        if (isMoving)
        {
            if (stepTimer >= stepInterval)
            {
                PlayFootstepSound();
                stepTimer = 0f;
            }
            else
            {
                stepTimer += Time.deltaTime;
            }
        }
        else
        {
            stepTimer = stepInterval;
        }
    }

    void PlayFootstepSound()
    {
        audioSource.PlayOneShot(footstepSound);
    }
}
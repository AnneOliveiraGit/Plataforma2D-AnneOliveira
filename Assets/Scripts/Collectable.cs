using UnityEngine;

public class Collectable : MonoBehaviour
{
    public static int totalCollected = 0;
    public AudioClip collectSound;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Toca o som no Player
            if (PlayerController.audioSourcePlayer != null && collectSound != null)
            {
                PlayerController.audioSourcePlayer.PlayOneShot(collectSound);
            }

            totalCollected++;
            Debug.Log("Coletado! Total: " + totalCollected);
            Destroy(gameObject);
        }
    }

    public static void ResetarContador()
    {
        totalCollected = 0;
    }
}

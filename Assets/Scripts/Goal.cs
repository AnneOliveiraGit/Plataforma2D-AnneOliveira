using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string proximaCena;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(proximaCena);
        }
    }
}

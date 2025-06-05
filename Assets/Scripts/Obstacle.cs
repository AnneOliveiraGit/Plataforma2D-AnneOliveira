using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            VidaManager vm = FindFirstObjectByType<VidaManager>();
            if (vm != null)
            {
                vm.PerderVida(); // Agora a cena é reiniciada só dentro de VidaManager
            }
        }
    }
}

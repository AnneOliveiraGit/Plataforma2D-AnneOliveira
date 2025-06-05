using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text coletavelText;

    void Start()
    {
        Collectable.ResetarContador(); // Reseta o contador ao iniciar a fase
    }

    void Update()
    {
        coletavelText.text = "Coletados: " + Collectable.totalCollected;
    }
}

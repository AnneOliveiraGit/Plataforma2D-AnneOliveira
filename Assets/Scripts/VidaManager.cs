using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaManager : MonoBehaviour {
    public Text vidaText;
    public static int vidas = 3;
    private static VidaManager instancia;
    private PlayerController playerController;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        SceneManager.sceneLoaded += OnSceneLoaded;

        // Tenta encontrar o PlayerController na cena
        playerController = FindObjectOfType<PlayerController>();
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        vidaText = GameObject.FindWithTag("VidaText")?.GetComponent<Text>();
        AtualizarHUD();

        // Atualiza a referência do PlayerController após a nova cena ser carregada
        playerController = FindObjectOfType<PlayerController>();
    }

    public void PerderVida()
    {
        vidas--;

        if (playerController != null)
        {
            playerController.TocarSomDano();
        }

        if (vidas <= 0)
        {
            vidas = 3;
            Collectable.ResetarContador();
        }

        Invoke(nameof(RecarregarCena), 0.1f);
    }

    private void RecarregarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void AtualizarHUD()
    {
        if (vidaText != null)
            vidaText.text = "Vidas: " + vidas;
    }

    void Update()
    {
        AtualizarHUD();
    }
}
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    [Header("Configuraci�n")]
    public int puntos = 1;  // Puntos que da al recolectar

    void OnTriggerEnter(Collider other)
    {
        // Verifica si es el jugador (aseg�rate que tenga tag "Player")
        if (other.CompareTag("Player"))
        {
            // Avisa al GameManager (si lo tienes)
            if (GameManager.Instance != null)
            {
                GameManager.Instance.SumarPuntos(puntos);
            }

            Destroy(gameObject); // Hace desaparecer el �tem
        }
    }
}
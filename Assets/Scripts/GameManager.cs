using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton (para acceder desde cualquier script)
    public static GameManager Instance;

    public int totalScore = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Persiste entre escenas
        }
        else
        {
            Destroy(gameObject); // Evita duplicados
        }
    }

    // Método para sumar puntos
    public void SumarPuntos(int puntos)
    {
        totalScore += puntos;
        Debug.Log("Puntos totales: " + totalScore);
    }
}
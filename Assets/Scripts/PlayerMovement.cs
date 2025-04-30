using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Velocidades")]
    public float forwardSpeed = 10f;  // Velocidad hacia adelante (autom�tica)
    public float lateralSpeed = 5f;   // Velocidad lateral (izquierda/derecha)

    void Update()
    {
        // Movimiento AUTOM�TICO hacia adelante (eje Z)
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);

        // Movimiento LATERAL con teclas (eje X)
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * lateralSpeed * Time.deltaTime);
    }
}
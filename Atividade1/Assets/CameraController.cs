using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float lookSpeed = 2f;

    private Vector2 moveInput;
    private Vector2 lookInput;

    private void Update()
    {
        // Movimento da câmera
        transform.Translate(moveInput.x * moveSpeed * Time.deltaTime, 0, moveInput.y * moveSpeed * Time.deltaTime);

        // Rotação da câmera
        float mouseX = lookInput.x * lookSpeed;
        float mouseY = lookInput.y * lookSpeed;

        // Ajuste de rotação (olhar para os lados)
        transform.Rotate(Vector3.up * mouseX, Space.World);

        // Rotação da câmera para cima/baixo
        Camera.main.transform.Rotate(Vector3.left * mouseY, Space.Self);
    }

    // Método chamado quando houver movimento
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    // Método chamado quando houver movimento do mouse
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }
}

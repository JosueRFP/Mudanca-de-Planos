using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(CharacterController))]
public class PlayerMov : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    CharacterController controller;
    Vector3 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        // Obtém o componente CharacterController anexado ao GameObject
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector3>();
        // moveInput atribui o valor do input lido do jogador
    }

    private void Update()
    {
        // Movementação do jogador com base no input recebido
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        controller.Move(move * Time.deltaTime * speed);
    }
}

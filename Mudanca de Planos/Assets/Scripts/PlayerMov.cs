using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [Header("PlayerSettings")]
    [SerializeField] private int playerID;
    [SerializeField] private float speed = 5f;

    Rigidbody rb;
    Vector3 moveInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(moveInput.x, rb.linearVelocity.y, moveInput.z);
    }

    void ReadInput()
    {
        float h = 0;
        float v = 0;

        if (playerID == 1)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical"); 
            
        }

       else if (playerID == 2)
       {
            
       }

        moveInput = new Vector3(h, 0, v) * speed;
    }
}

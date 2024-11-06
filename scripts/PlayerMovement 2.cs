using UnityEngine;

public class PlayerMovementP2 : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("HorizontalP2");
        movement.y = Input.GetAxisRaw("VerticalP2");
    }

    void FixedUpdate()
    {
       
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}

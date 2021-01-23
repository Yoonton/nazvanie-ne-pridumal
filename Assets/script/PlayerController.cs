using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForse;
    private float moveInput;
    private Rigidbody2D rb;
    public bool facingRight = true;
    private bool isGround;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJupms;
    public int extraJumpsValue;
    private void Start()
    {
        extraJupms = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput < 0)
        {
            Flip();
        }
    }
    public void Update()
    {
        if(isGround == true)
        {
            extraJupms = extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.Space) && extraJupms > 0)
        {
            rb.velocity = Vector2.up * jumpForse;
            extraJupms--; 
        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJupms == 0 && isGround == true)
        {
            rb.velocity = Vector2.up * jumpForse;
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}

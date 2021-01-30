using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityChange : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool top;
    private PlayerController player;
    private bool triggerEnter = false;
    private Vector2 gravity = Physics.gravity;
    [SerializeField] int rl = 100;
    private void Start()
    {
        player = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {        
        if (!(triggerEnter))
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                rb.gravityScale *= -1;
                Rotate();
            }
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Physics2D.gravity = Vector2.right * rl;
            rl = rl * -1;
        }
    } 
    void Rotate()
    {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        player.facingRight = !player.facingRight;
        top = !top;
    }
    public void OnTriggerEnter2D(Collider2D collision)
     {
        triggerEnter = true;
        rb.gravityScale *= -1;
        Rotate();
     }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggerEnter = false;
    }
}

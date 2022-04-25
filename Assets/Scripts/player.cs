using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public Animator animator;
    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void FixedUpdate()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        
        //animator.SetFloat("Vertical", direction.y);
        //animator.SetFloat("Speed", direction.sqrMagnitude);

        if(direction.x < 0 | (transform.localScale.x < 0 & direction.y != 0)){
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("isRunningRight", true);
        }
            else if(direction.x > 0 | (transform.localScale.x > 0 & direction.y != 0)){
                transform.localScale = new Vector3(1, 1, 1);
                animator.SetBool("isRunningRight", true);
            } else animator.SetBool("isRunningRight", false);

        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}

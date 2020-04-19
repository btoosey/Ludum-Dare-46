using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public GameObject plant;
    public Animator animator;
    public int flies;

    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        SetSpeed();
        if (GameObject.FindGameObjectsWithTag("Fly").Length == 0)
        {
            FindObjectOfType<GameManager>().Win();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void SetSpeed()
    {
        moveSpeed = 3f;
    }

    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "Fly")
        {
            Destroy(triggerCollider.gameObject);
            plant.GetComponent<Plant>().GainHealth(4);
        }
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Drinkable")
        {
            plant.GetComponent<Plant>().GainWater(6);
        }
    }
}

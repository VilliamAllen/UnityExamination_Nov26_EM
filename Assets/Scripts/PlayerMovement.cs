using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public ParticleSystem footstepDust;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movement = Vector2.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) movement.y += 1;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) movement.y -= 1;
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) movement.x -= 1;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) movement.x += 1;
        }

        movement.Normalize();

        anim.SetFloat("Speed", movement.sqrMagnitude);

        if (footstepDust != null)
        {
            if (movement.sqrMagnitude > 0.1f && !footstepDust.isPlaying)
                footstepDust.Play();
            else if (movement.sqrMagnitude <= 0.1f && footstepDust.isPlaying)
                footstepDust.Stop();
        }

        if (movement.x != 0)
            transform.localScale = new Vector3(Mathf.Sign(movement.x), 1, 1);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
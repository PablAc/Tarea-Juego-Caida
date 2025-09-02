using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField] float terminalVelocity;
    [SerializeField] float moveSpeed;
    bool isFacingRight;
    Rigidbody2D myRb;
    float hMovement;

    private void Awake()
    {
        myRb = GetComponent<Rigidbody2D>();
        isFacingRight = false;
    }

    private void Update()
    {
        myRb.linearVelocity = new Vector2(hMovement * moveSpeed, myRb.linearVelocity.y);
        if (myRb.linearVelocityY < terminalVelocity)
        {
            myRb.linearVelocityY = terminalVelocity;
        }
        flip();
    }
    public void Move(InputAction.CallbackContext context)
    {
        hMovement = context.ReadValue<Vector2>().x;
    }
    private void flip()
    {
        if (isFacingRight && myRb.linearVelocityX < 0 || !isFacingRight && myRb.linearVelocityX > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 x = transform.localScale;
            x.x *= -1f;
            transform.localScale = x;
        }
    }
}

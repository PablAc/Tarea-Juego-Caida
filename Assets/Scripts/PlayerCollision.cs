using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    CharacterController myController;

    private void Awake()
    {
        myController = GetComponent<CharacterController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Spike"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.CompareTag("Spd"))
        {
            float x = collision.GetComponent<SpdChanger>().alterSpeed;
            myController.changeMaxFallSpeed(x);
        }
    }
}

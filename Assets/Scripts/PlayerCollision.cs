using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    CharacterController myController;
    [SerializeField] GameObject camera;

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
        else if (collision.CompareTag("Cam"))
        {
            CameraController cc = camera.GetComponent<CameraController>();
            cc.enabled = false;
        }
    }
}

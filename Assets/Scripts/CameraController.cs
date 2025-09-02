using UnityEngine;

public class CameraController : MonoBehaviour
{
    float startX;
    float yDifference;
    [SerializeField] Transform target;

    private void Awake()
    {
        startX = this.transform.position.x;
        yDifference = this.transform.position.y- target.transform.position.y;
    }
    private void Update()
    {
        this.transform.position = new Vector3(startX, yDifference + target.transform.position.y, this.transform.position.z);
    }

}

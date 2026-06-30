using UnityEngine;

public class FallingObjectController : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 2.5f;
    [SerializeField] private float topY = 5.5f;
    [SerializeField] private float bottomY = -5.5f;
    [SerializeField] private float horizontalRange = 4f;

    private void OnEnable()
    {
        ResetPosition();
    }

    private void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;

        if (transform.position.y < bottomY)
        {
            ResetPosition();
        }
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-horizontalRange, horizontalRange);
        transform.position = new Vector3(randomX, topY, transform.position.z);
    }
}

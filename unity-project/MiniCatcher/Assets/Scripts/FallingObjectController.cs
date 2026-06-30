using UnityEngine;

public class FallingObjectController : MonoBehaviour
{
    [SerializeField] private float fallSpeed = 2.5f;
    [SerializeField] private float topY = 5.5f;
    [SerializeField] private float bottomY = -5.5f;
    [SerializeField] private float horizontalRange = 4f;
    [SerializeField] private GameManager gameManager;

    private Rigidbody2D objectBody;

    private void Awake()
    {
        objectBody = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        ResetPosition();
    }

    private void FixedUpdate()
    {
        Vector2 nextPosition = objectBody.position
            + Vector2.down * fallSpeed * Time.fixedDeltaTime;

        objectBody.MovePosition(nextPosition);

        if (nextPosition.y < bottomY)
        {
            bool gameContinues = gameManager.LoseLife();

            if (gameContinues)
            {
                ResetPosition();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        gameManager.AddScore();
        ResetPosition();
    }

    private void ResetPosition()
    {
        float randomX = Random.Range(-horizontalRange, horizontalRange);
        objectBody.position = new Vector2(randomX, topY);
    }
}

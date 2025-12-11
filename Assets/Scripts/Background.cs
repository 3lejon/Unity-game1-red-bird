using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 5f;   // Speed of background movement
    private Vector3 startPosition;
    private float tileWidth;

    void Start()
    {
        startPosition = transform.position;
        tileWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // Reset position when tile goes off-screen
        if (transform.position.x < -tileWidth)
        {
            transform.position = new Vector3(transform.position.x + 2 * tileWidth, transform.position.y, transform.position.z);
        }
    }
}

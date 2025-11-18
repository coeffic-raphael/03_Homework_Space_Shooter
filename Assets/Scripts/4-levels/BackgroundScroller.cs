using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 1f;
    private float spriteHeight;
    private void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr != null)
        {
            spriteHeight = sr.bounds.size.y;
        }
        else
        {
            Debug.LogError("[BackgroundScroller] No SpriteRenderer found on " + gameObject.name);
        }
    }

    private void Update()
    {
        transform.position += Vector3.down * scrollSpeed * Time.deltaTime;
        if (transform.position.y <= -spriteHeight)
        {
            transform.position += new Vector3(0f, spriteHeight * 2f, 0f);
        }
    }
}

using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 originalPos;
    public Rigidbody2D rigidbody;
    void Start()
    {
        originalPos = transform.position;
        rigidbody = GetComponent<Rigidbody2D>();
        RandomGravity();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            rigidbody.linearVelocity = Vector2.zero;
            RandomGravity();
            transform.position = originalPos;
        }
    }

    private void RandomGravity()
    {
        float random = Random.Range(0.5f, 3);
        rigidbody.gravityScale = random;
    }

}

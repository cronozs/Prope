using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0) * (Time.deltaTime * speed);
            spriteRenderer.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * (Time.deltaTime * speed);
            spriteRenderer.flipX = false;
        }
    }
}

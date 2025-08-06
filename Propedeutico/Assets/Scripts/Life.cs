using UnityEngine;

public class Life : MonoBehaviour
{
    public int hp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp--;
        Debug.Log("el HP es igual a:" + hp);

        if(hp <=0)
        {
            Debug.Log("Perdiste");
            Time.timeScale = 0;
        }
    }
}

using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 5f;
    public static Target compartilharTarget;
    //  public GameObject caco;
    private bool borracha = false;
    public  int scorePoints = 10;
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            borracha = true;
            Die();
        }
        if (health <= 0 && borracha == true)
        {
            health = 1;
        }

    }

    void Die ()
    {
        Score.score += scorePoints;
      //  Instantiate(caco, transform.position, transform.rotation);
        gameObject.SetActive(false);      
    }
}
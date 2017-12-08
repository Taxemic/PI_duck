using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatinhoController : MonoBehaviour
{

    public static PatinhoController compartilhaPato;
    private Animator pato;
    public int perdeu = 1;
    private void OnEnable()
    {
        pato = this.GetComponent<Animator>();
        pato.SetBool("Andando", true);     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Black Hole")
        {
            if (gameObject.tag == "Pato"|| gameObject.tag == "PatoMeio"|| gameObject.tag == "PatoTopo")
            {
                gameObject.SetActive(false);
                perdeu--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
    
}

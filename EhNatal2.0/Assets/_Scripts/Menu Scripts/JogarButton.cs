using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogarButton : MonoBehaviour {

    Animator anim;

    public SpriteRenderer Jogar;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        Jogar.color = new Color(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        Jogar.color = new Color(0.5f, 0.5f, 0.5f);
    }
    void OnMouseExit()
    {
        Jogar.color = new Color(1f, 1f, 1f, 1f);
    }
    void OnMouseDown()
    {
        anim.SetBool("Clicado", true);
    }
    void OnMouseUp()
    {
        anim.SetBool("Clicado", false);
        SceneManager.LoadScene("Teste");
    }
}
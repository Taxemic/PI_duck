using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoltarMenuButton : MonoBehaviour {

    Animator anim;

    public Camera cameraVoltar;

    public SpriteRenderer VoltarMenu;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        VoltarMenu.color = new Color(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        VoltarMenu.color = new Color(0.5f, 0.5f, 0.5f);
    }
    void OnMouseExit()
    {
        VoltarMenu.color = new Color(1f, 1f, 1f, 1f);
    }
    void OnMouseDown()
    {
        anim.SetBool("Clicado", true);
    }
    void OnMouseUp()
    {
        anim.SetBool("Clicado", false);
        cameraVoltar.transform.position = new Vector3(0f, 1f, -15f);

    }
}
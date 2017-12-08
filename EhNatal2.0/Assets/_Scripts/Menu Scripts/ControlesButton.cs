using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesButton : MonoBehaviour {

    Animator anim;

    public Camera cameraControles;

    public SpriteRenderer Controles;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

        Controles.color = new Color(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        Controles.color = new Color(0.5f, 0.5f, 0.5f);
    }
    void OnMouseExit()
    {
        Controles.color = new Color(1f, 1f, 1f, 1f);
    }
    void OnMouseDown()
    {
        anim.SetBool("Clicado", true);
    }
    void OnMouseUp()
    {
        anim.SetBool("Clicado", false);
        cameraControles.transform.position = new Vector3(24.5f, 1f, -15f);
    }
}
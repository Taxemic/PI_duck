using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditosButton : MonoBehaviour {

    Animator anim;

    public Camera cameraCreditos;

    public SpriteRenderer Credito;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

        Credito.color = new Color(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseEnter()
    {
        Credito.color = new Color(0.5f, 0.5f, 0.5f);
    }
    void OnMouseExit()
    {
        Credito.color = new Color(1f, 1f, 1f, 1f);
    }
    void OnMouseDown()
    {
        anim.SetBool("Clicado", true);
    }
    void OnMouseUp()
    {
        anim.SetBool("Clicado", false);
        cameraCreditos.transform.position = new Vector3(49f, 1f, -15f);
    }
}
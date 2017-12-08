using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class AlvoController : MonoBehaviour
{
    #region movimentação
    public float velocidade = 10.0f;
    Rigidbody rb;
    #endregion 
    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
    }
 
    void FixedUpdate ()
    {
        //movimentação da Mira
        float DirX = CrossPlatformInputManager.GetAxis("Horizontal");
        float DirY = CrossPlatformInputManager.GetAxis("Vertical");
        rb.velocity = new Vector2(DirX * velocidade / 2, DirY * velocidade / 2);
        
    }
}

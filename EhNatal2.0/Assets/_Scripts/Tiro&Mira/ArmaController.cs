using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaController : MonoBehaviour
{
    public GameObject /*bala,*/mira;
    //public Transform escape;

    private Ray raio;
    private RaycastHit ponto;

    private Vector3 metrosFrente;

    public Camera cam;
    public GameObject armaMira;
    public Transform armaSeguir;

    public float damage = 1f;
    public float range = 10f;
    public float FireRate = 5f;
    public float ImpactForce = 100f;

    private float NextTimeToFire = 0f;


    // Update is called once per frame
    void Update ()
    {
        // raio = cam.ScreenPointToRay(Input.mousePosition);
        raio = cam.ScreenPointToRay(mira.transform.position);
        if (Physics.Raycast(raio,out ponto, 100))
        {
            armaSeguir.LookAt(mira.transform.position);//veja tutorial spaceshooter, para um melhor aproveitamento.
        }
        else
        {
            metrosFrente = cam.transform.position + raio.direction * 10;
            transform.LookAt(metrosFrente);
        }
        if (Input.GetKey(KeyCode.F) & Time.time >= NextTimeToFire)
        {
            NextTimeToFire = Time.time + 1f / FireRate;
            Debug.DrawRay(transform.position, armaMira.transform.forward, Color.green);
            Shoot();
        }

    }
    public void Shoot()
    {
        // Particula que sai da arma ao atirar
        //MuzzleFlash.Play();

        RaycastHit hit;
        if (Physics.Raycast(armaMira.transform.position, armaMira.transform.forward, out hit, range))
        {
            Debug.DrawRay(hit.point,armaMira.transform.forward, Color.green);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * ImpactForce);
            }

            //Particula ao ocorrer impacto no alvo
            //GameObject Impact = Instantiate(ImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            //Destroi a particula apos 2 segundos
            //Destroy(Impact, 2f);

        }
    }
}

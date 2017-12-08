﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawnerBaixo : MonoBehaviour
{
    private float proximoSpawn;
    [SerializeField]
    private GameObject patoPrefab;
    [SerializeField]
    private float spawnDelay = 10;

    void Update()
    {
        if (ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject pato = ObjectPooler.compartilhada.PegarObjetoAgrupado("Pato");
        if (pato != null)
        {
            proximoSpawn = spawnDelay = Random.Range(1, 10);
            pato.transform.position = transform.position;
            pato.transform.rotation = transform.rotation;
           // Instantiate(pato, transform.position, transform.rotation);
            pato.SetActive(true);
        }
       
       

    }
    private bool ShouldSpawn()
    {
        return Time.time >= proximoSpawn;
    }
}

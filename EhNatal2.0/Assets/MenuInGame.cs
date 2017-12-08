using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    private int perdeuGame;
    public GameObject telaGameOver;

    // Update is called once per frame
    void Update()
    {
        perdeuGame = PatinhoController.compartilhaPato.perdeu;
        if (perdeuGame <= 0)
        {
            Time.timeScale = 0;
            telaGameOver.SetActive(true);
        }
        
    }
}

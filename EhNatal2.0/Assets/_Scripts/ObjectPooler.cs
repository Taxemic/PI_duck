using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectPoolItem
{
    public GameObject objetosParaAgrupar;
    public int quantosObjetos;
    public bool expanda;
}
public class ObjectPooler : MonoBehaviour {

    public static ObjectPooler compartilhada;

    public List<ObjectPoolItem> itensparAgrupar;
    public List<GameObject>objetosAgrupados;

    public bool expanda = true;

    void Awake()
    {
        compartilhada = this;
    }
    void Start()
    {
        objetosAgrupados = new List<GameObject>();
        foreach(ObjectPoolItem item in itensparAgrupar)
        {
            for (int i = 0; i < item.quantosObjetos; i++)
            {
                GameObject obj = (GameObject)Instantiate(item.objetosParaAgrupar);
                obj.SetActive(false);
                objetosAgrupados.Add(obj);
            }
        }
    }
    public GameObject PegarObjetoAgrupado(string tag)
    {
        for (int i = 0; i < objetosAgrupados.Count; i++)
        {
            if (!objetosAgrupados[i].activeInHierarchy && objetosAgrupados[i].tag == tag)
            {
                return objetosAgrupados[i];
            }
        }
        foreach(ObjectPoolItem item in itensparAgrupar)
        {
            if (item.objetosParaAgrupar.tag == tag)
            {
                if (item.expanda)
                {
                    GameObject obj = (GameObject)Instantiate(item.objetosParaAgrupar);
                    obj.SetActive(false);
                    objetosAgrupados.Add(obj);
                    return obj;
                }
            }
        }
        return null;
    }
}

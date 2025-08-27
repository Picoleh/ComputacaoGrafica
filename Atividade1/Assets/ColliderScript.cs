using System;
using UnityEngine;
using UnityEngine.UI;

public class ColliderScript : MonoBehaviour
{
    [SerializeField] public GameObject col;
    public Text goal;
    void Start()
    {
        Debug.Log("opa");
        int x = 0, z = 0;
        String direcao = "";
        switch (UnityEngine.Random.Range(0, 4))
        {
            case 0:
                x = 0;
                z = 10;
                direcao = "norte";
                break;
            case 1:
                x = 0;
                z = -10;
                direcao = "sul";
                break;
            case 2:
                x = 10;
                z = 0;
                direcao = "leste";
                break;
            case 3:
                x = -10;
                z = 0;
                direcao = "oeste";
                break;
            default:
                break;
        }

        Debug.Log("Iniciado em " + x + " " + z);
        goal.text += direcao;
        Instantiate(col, new Vector3(x, 10, z), transform.rotation);
    }
}

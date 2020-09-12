using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerIf : MonoBehaviour
{
    public int puntos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            puntos =50;
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            puntos =100;
        }

        switch (puntos)
        {
            case 50:
            Debug.Log("Baja la velocidad");
            break;


            case 100:
            Debug.Log("Baja la velocidad");
            break;

            default:
                Debug.Log("Se debe ingresar otro resultado");

                break;
        }


    }
}

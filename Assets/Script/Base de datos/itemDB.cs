using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDB : MonoBehaviour
{
    [SerializeField]
    public item[] items;
    public item pedro;

    // Start is called before the first frame update
    void Start()
    {
        items[0] = new item("Pedro", "Diaz", 18,"Hombre", "Panadero");
        items[1] = new item("Jorge", "Perez", 20,"Hombre", "chef");
        items[2] = new item("Carlos", "Molina", 15,"Hombre", "creador");
        items[3] = new item("Karla", "Diaz", 21,"Mujer", "Carnicera");
        pedro = new item("Katana", "Diaz", 3,"Mujer", "Asesina");

    }
}

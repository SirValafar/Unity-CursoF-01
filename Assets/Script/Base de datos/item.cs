using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class item
{
    public string Fname;
    public string Lname;
    public int age;
    public string gender;
    public string ocupacion;

    public item(){}

    public item(string Fname,string Lname, int age, string gender, string ocupacion)
    {
        this.Fname = Fname;
        this.Lname = Lname;
        this.age = age;
        this.gender = gender;
        this.ocupacion = ocupacion;
    }
}
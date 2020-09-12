using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _horizontal;

    [SerializeField]
    private float _vertical;
    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(_horizontal, _vertical, 0) * Time.deltaTime * _speed);
    }
}

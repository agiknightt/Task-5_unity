using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            MoverPosition(_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MoverPosition(_speed * Time.deltaTime * -1);
        }
    }

    private void MoverPosition(float x = 0, float y = 0)
    {
        transform.Translate(x, y, 0);
    }
}

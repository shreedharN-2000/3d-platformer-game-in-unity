using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class GemRotate : MonoBehaviour {

    public int rotateSpeed = 2;

    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bilye : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
    }

}

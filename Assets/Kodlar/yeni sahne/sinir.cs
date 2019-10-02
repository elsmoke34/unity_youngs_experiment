using UnityEngine;

public class sinir : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
       
        Destroy(other.gameObject);
    }
}

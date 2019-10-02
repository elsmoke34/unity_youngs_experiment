using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taban : MonoBehaviour {

    Rigidbody fizik;
    public GameObject Parcacik;
    public Transform ParcacikNeredenCiksin;
    float atisZamani=0;
    public float atistaGecenSure=0;

	
	void Start ()
    {
        fizik = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        if (Input.GetButton("Fire1")&& Time.time>atisZamani)
        {
            atisZamani = Time.time + atistaGecenSure;
            Instantiate(Parcacik, ParcacikNeredenCiksin.position, Quaternion.identity);
            
        }
	}
}

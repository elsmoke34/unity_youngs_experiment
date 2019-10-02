using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropdown : MonoBehaviour
{
    public Dropdown acilirListe;
    public GameObject ikiliIz;
    public GameObject kuantumizi;
    public GameObject dalgaIzi;
    public ParticleSystem emitter;
    public GameObject gozlemci;
    public GameObject kutu;
    public GameObject bilyeduscek;
    public GameObject dalgaTexture;
    public GameObject DurgunSu;
   

    List<string> secenekler = new List<string>() { "Seçiniz", "Parçacık", "Dalga", "Kuantum Nesnesi", "Gözlemci Ekle" };

    void Start()
    {
        PopulateList(); //ilk başlayınca listeyi şey etcek   
    }

    void PopulateList()
    {
        acilirListe.AddOptions(secenekler);
    }


    public void DropdownSecildiginde(int index)
    {
        NewMethod(index);
    }

    private void NewMethod(int index)
    {
        switch (index)
        {
            case 0: //*seciniz
                break;

            case 1: //parcacik ikili
                Temizlik();

                kutu.SetActive(true);
                emitter.GetComponent<ParticleSystem>().Play();
                StartCoroutine(BekletmeIkiliIzIcin());
                    break;

            case 2: //dalga çoklu 
                Temizlik();

                kutu.SetActive(false);
                DurgunSu.SetActive(true);
                StartCoroutine(Bekletme());
                    break;

            case 3: //kuantum çoklu
                Temizlik();

                kutu.SetActive(true);
                emitter.GetComponent<ParticleSystem>().Play();
                StartCoroutine(KuantumIcin());
                    break;

            case 4: //gözlemci ikili
                Temizlik();

                kutu.SetActive(true);
                gozlemci.SetActive(true);
                emitter.GetComponent<ParticleSystem>().Play();
                StartCoroutine(BekletmeIkiliIzIcin());
                    break;
        }
    }

    private void OnTriggerEnter(object other)
    {
        throw new NotImplementedException();
    }

    IEnumerator BekletmeIkiliIzIcin()
     {
        yield return new WaitForSeconds(3.5f);
        ikiliIz.SetActive(true);
        emitter.GetComponent<ParticleSystem>().Stop();
     }

    IEnumerator KuantumIcin()
    {
        yield return new WaitForSeconds(3.5f);
        kuantumizi.SetActive(true);
        emitter.GetComponent<ParticleSystem>().Stop();
    }

    IEnumerator DalgaIcin()
    {
        
        yield return new WaitForSeconds(3.5f);
        dalgaTexture.SetActive(true);
    }
    
    IEnumerator Bekletme()
    {
        yield return new WaitForSeconds(2f);
        bilyeduscek.SetActive(true);
        yield return new WaitForSeconds(1f);
        dalgaIzi.SetActive(true);
        StartCoroutine(DalgaIcin());
    }

    void Temizlik()
    {
        gozlemci.SetActive(false);
        dalgaTexture.SetActive(false);
        kuantumizi.SetActive(false);
        dalgaIzi.SetActive(false);
        ikiliIz.SetActive(false);
        bilyeduscek.SetActive(false);
        dalgaTexture.SetActive(false);
        DurgunSu.SetActive(false);

    }

    



}
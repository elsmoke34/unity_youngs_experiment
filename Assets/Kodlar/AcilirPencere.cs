//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class AcilirPencere : MonoBehaviour
//{
//    public Dropdown acilirListe;    //referans
//    List<string> secenekler = new List<string>() { "Seçiniz", "Parçacık", "Dalga", "Kuantum Nesnesi", "Gözlemci Ekle" };   //seçenekleri unityden almak için
    

//    void Start()
//    {
//        PopulateList(); //ilk başlayınca listeyi şey etcek
//    }

//    void PopulateList()
//    {
//        acilirListe.AddOptions(secenekler);
//    }

//    public void DropdownSecildiginde(int index)
//    {
//        switch (index)
//        {
//            case 0: // index = 1 olduğunda  seciniz kısmı bunluk bi şey yok
//                break;

//            case 1: //index = 2 olduğunda    *parcacik
//                 break;

//            case 2: // index = 3 olduğunda   *dalga
//                break;

//            case 3: // index = 4 olduğunda    *kuantum
//                 break;

//            case 4: // index = 5 olduğunda    *gözlemci eklenince
//                break;
//        }
//    }



//    void PopulateList()
//    {
//        acilirListe.AddOptions(secenekler);
//    }

    

//}

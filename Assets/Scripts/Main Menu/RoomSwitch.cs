using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomSwitch : MonoBehaviour
{
    public string scenename;
 
 void OnTriggerEnter(Collider other){
  if(other.CompareTag("Player")){
   SceneManager.LoadScene(scenename);
  }
 }
}
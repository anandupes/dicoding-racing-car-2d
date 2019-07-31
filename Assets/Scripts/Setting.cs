using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class Setting : MonoBehaviour {
 
   // teks representasi untuk persen
   Text persenTeks;
 
   // Use this for initialization
   void Start() {
       persenTeks = GetComponent<Text>();
 

   }
 
   // toggle untuk fullscreen
   public void TampilanPenuh (bool isFullscreen) {
       Screen.fullScreen = isFullscreen;
   }

 
   // teks untuk persen
   public void Volume (float value) {
       persenTeks.text = Mathf.RoundToInt(value * 100) + "%";
   }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text score; 
    public static UI_Manager singleton;
    // Start is called before the first frame update
  public void UpdateUI(){
      score.text = "Score: "+GameManager.singleton.score1+"- Score2: "+GameManager.singleton.score2;
  }
  private void Awake() {
      singleton=this;
  }
}

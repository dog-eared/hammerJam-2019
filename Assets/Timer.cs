﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Timer : MonoBehaviour
{

  public int timeLeft = 60; //Seconds Overall
  public Text TimerLabel; //UI Text Object
  void Start () {
    StartCoroutine("LoseTime");
    Time.timeScale = 1; //Just making sure that the timeScale is right
  }
  void Update () {
    TimerLabel.text = ("" + timeLeft); //Showing the Score on the Canvas
  }
  //Simple Coroutine
  IEnumerator LoseTime()
  {
    while (timeLeft > 0) {
      yield return new WaitForSeconds (1);
      timeLeft--; 
    }
    GameOver.showStuff();
    }
}
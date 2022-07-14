using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;
    public bool F1Race = false;
    public Text WrongCar;
    public void OptionsOn()
    {
        if (F1Race == true) 
        { 
            if (Savedscript.SportsCarID == 1)
            {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            }
            if (Savedscript.SportsCarID > 1)
            {
                WrongCar.text = "YOU NEED TO BE IN A F1 CAR";
                StartCoroutine(ResetText());
            }

        }
       
        if (F1Race == false)
        {
            if (Savedscript.SportsCarID > 1 )
            {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            }
            if (Savedscript.SportsCarID == 1)
            {
                WrongCar.text = "YOU NEED TO BE IN A SPORTS CAR";
                StartCoroutine(ResetText());
            }
        }
    }
   public void OptionsOff()
    {
        TrackOptions.SetActive(false); 
    }

    IEnumerator ResetText()
    {
        yield return new WaitForSeconds(3);
        WrongCar.text = " ";  
    }
}

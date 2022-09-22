using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    [SerializeField] GameObject GreenOkey;
    [SerializeField] GameObject RedOkey;
    [SerializeField] GameObject OrangeOkey;

    //------------------------------------------------------

    public static int CurrentFloorColorID;

    private int GreenFloorID=1;
    private int RedFloorID=2;
    private int OrangeFloorID=3;

    //------------------------------------------------------


    public void GreenButton()
    {
        CurrentFloorColorID = GreenFloorID;
        //----------------------------
        GreenOkey.SetActive(true);
        RedOkey.SetActive(false);
        OrangeOkey.SetActive(false);
    }

    public void RedButton()
    {
        CurrentFloorColorID = RedFloorID;
        //----------------------------
        GreenOkey.SetActive(false);
        RedOkey.SetActive(true);
        OrangeOkey.SetActive(false);
    }

    public void OrangeButton()
    {
        CurrentFloorColorID = OrangeFloorID;
        //----------------------------
        GreenOkey.SetActive(false);
        RedOkey.SetActive(false);
        OrangeOkey.SetActive(true);
    }

    
}

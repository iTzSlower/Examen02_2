using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text test;
    public Player player;
    public int option;
    private void Update()
    {
        Cool(option);
    }
    public void Cool(int option)
    {
        switch (option)
        {
            case 0:
                test.text = "MUERTES: " + player.deaths;
                break;
            case 1:
                test.text = "GANADAS: " + player.wins;
                break;
            default:
                break;
        }
    }
}

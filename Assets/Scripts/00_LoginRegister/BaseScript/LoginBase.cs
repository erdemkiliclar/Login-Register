using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginBase 
{
    





    public void Login(string Username, string Password, Text _resultText)
    {

        string TempUsername = PlayerPrefs.GetString("Username");
        string TempPassword = PlayerPrefs.GetString("Password");


        if (Username==TempUsername && Password == TempPassword)
        {
            _resultText.text = "Giris basarilir";
        }

        else
        {
            _resultText.text = "kullanici bilgileri yanlis";
        }

    }

}

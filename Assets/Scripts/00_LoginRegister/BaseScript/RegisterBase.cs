using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterBase
{

    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RepeatPassword { get; set; }


    public bool IsRegister_Async { get; set; }

    public void Register(Text _resultText)
    {
        PlayerPrefs.SetString("Email", Email);
        PlayerPrefs.SetString("Username", Username);
        PlayerPrefs.SetString("Password", Password);

        IsRegister_Async = true;
        _resultText.text = "Kayit Basarili";
    }

}

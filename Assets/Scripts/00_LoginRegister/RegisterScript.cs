using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScript : MonoBehaviour
{
    [SerializeField] InputField _username, _email, _password, _repeatPassword;
    [SerializeField] Text _resultText;
    RegisterBase _registerBase = new RegisterBase();
    
    [SerializeField] string _usernameSt, _emailSt, _passwordSt;
    [SerializeField] Button _registerButton;

    private void Start()
    {
        _usernameSt = PlayerPrefs.GetString("Username");
        _emailSt = PlayerPrefs.GetString("Email");
        _passwordSt = PlayerPrefs.GetString("Password");
    }

    
   

    public void RegisterOnClick()
    {
        _registerBase.Username = _username.text;
        _registerBase.Email = _email.text;
        _registerBase.Password = _password.text;
        _registerBase.RepeatPassword = _repeatPassword.text;

        _registerBase.Register(_resultText);
    
    }

    public void InputControllers()
    {
        if (_username.text.Length < 5 || _password.text != _repeatPassword.text || _email.text.IndexOf('@') < 0 || _email.text.IndexOf('.') < 0 || _password.text.Length < 6)
        {
            _registerButton.interactable = false;
        }
        else
        {
            _registerButton.interactable = true;
        }
    }

}

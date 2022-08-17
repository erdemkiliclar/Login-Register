using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginScript : MonoBehaviour
{
    [SerializeField] Button _loginButton;
    [SerializeField] InputField _username, _password;
    [SerializeField] Text _resultText;
    LoginBase _loginBase = new LoginBase();


    public void LoginOnClick()
    {
        _loginBase.Login(_username.text, _password.text,_resultText);
    }

    public void InputControllers()
    {
        if (_username.text.Length < 5 ||  _password.text.Length < 6 )
        {
            _loginButton.interactable = false;
        }
        else
        {
            _loginButton.interactable = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : RegisterBase
{

   


    public void InputControllerOnClick(Button _RegisterButton)
    {
        if (Username.Length < 5 || Password != RepeatPassword || Email.IndexOf('@') < 0 || Email.IndexOf('.') < 0 || Password.Length < 6)
        {
            _RegisterButton.interactable = false;
        }
        else
        {
            _RegisterButton.interactable = true;
        }
    }

    
    



}

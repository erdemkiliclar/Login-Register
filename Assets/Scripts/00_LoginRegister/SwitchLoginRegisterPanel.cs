using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLoginRegisterPanel : MonoBehaviour
{


    [SerializeField] GameObject _loginPanel, _registerPanel;

    private void Start()
    {
        SwitchPanel();
    }


    public void SwitchPanel()
    {
        switch (_registerPanel.activeInHierarchy)
        {
            case true:
                _registerPanel.SetActive(false);
                _loginPanel.SetActive(true);
                break;
            case false:
                _registerPanel.SetActive(true);
                _loginPanel.SetActive(false);
                break;

        }   
    }

}

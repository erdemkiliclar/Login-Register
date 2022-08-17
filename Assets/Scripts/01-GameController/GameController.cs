using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] Text _randomNumberText;

    int _random;


    Dictionary<string, int> _userList = new Dictionary<string, int>();
    public void RandomTextClick()
    {
        _random = Random.Range(1, 1000000);
        _randomNumberText.text = _random.ToString();
    }


    public void SaveUserAndScore()
    {
        _userList.Add(PlayerPrefs.GetString("Username"), _random);
    }


    public void GetUserList()
    {
        foreach (var item in _userList)
        {
            Debug.Log(item);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
    [SerializeField]
    [Header("リザルト画面のパネル")]
    Image _resultPanel;

    [SerializeField]
    [Header("結果を反映するUI")]
    ScoreUI[] _scoreUIs;


    [System.Serializable]
    class ScoreUI
    {
        [SerializeField]
        string _name;

        [SerializeField]
        Text _text;

        void ChangeText(string text)
        {
            //_text.text = 
        }
    }
}

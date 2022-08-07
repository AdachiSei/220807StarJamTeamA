using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : SingletonMonoBehaviour<ResultUIManager>
{
    [SerializeField]
    [Header("リザルト画面のパネル")]
    Image _resultPanel;

    [SerializeField]
    [Header("結果を反映するUI")]
    ScoreUI[] _scoreUIs;

    protected override void Awake()
    {
        base.Awake();
        ResultSetActive(false);
        ChangeText(0, 0);
    }

    /// <summary>テキストを変更(時間, スコア)</summary>
    public void ChangeText(int time,int score)
    {
        _scoreUIs.FirstOrDefault(x => x.ScoreType == ScoreType.Timer).ChangeText(time);
        _scoreUIs.FirstOrDefault(x => x.ScoreType == ScoreType.Score).ChangeText(score);
    }

    public void ResultSetActive(bool active)
    {
        _resultPanel.gameObject.SetActive(active);
    }

    [System.Serializable]
    class ScoreUI
    {
        public ScoreType ScoreType => _scoreType;

        [SerializeField]
        [Tooltip("名前")]
        string _name;

        [SerializeField]
        [Tooltip("種類")]
        ScoreType _scoreType;

        [SerializeField]
        [Tooltip("テキスト")]
        Text _text;

        public void ChangeText(int score)
        {
            _text.text = _name + "  " +score.ToString();
        }
    }
}

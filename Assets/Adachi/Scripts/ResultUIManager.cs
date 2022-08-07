using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ResultUIManager : SingletonMonoBehaviour<ResultUIManager>
{
    [SerializeField]
    [Header("���U���g��ʂ̃p�l��")]
    Image _resultPanel;

    [SerializeField]
    [Header("���ʂ𔽉f����UI")]
    ScoreUI[] _scoreUIs;

    protected override void Awake()
    {
        base.Awake();
        ResultSetActive(false);
        ChangeText(0, 0);
    }

    /// <summary>�e�L�X�g��ύX(����, �X�R�A)</summary>
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
        [Tooltip("���O")]
        string _name;

        [SerializeField]
        [Tooltip("���")]
        ScoreType _scoreType;

        [SerializeField]
        [Tooltip("�e�L�X�g")]
        Text _text;

        public void ChangeText(int score)
        {
            _text.text = _name + "  " +score.ToString();
        }
    }
}

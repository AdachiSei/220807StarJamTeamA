using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    [SerializeField]
    [Header("タイトル")]
    AudioClip _titleBGM;

    [SerializeField]
    [Header("ゲーム")]
    AudioClip _gameBGM;

    [SerializeField]
    [Header("リザルト")]
    AudioClip _resultBGM;

    [SerializeField]
    [Header("プレイヤーが死んだときの音")]
    AudioClip _deathSFX;

    [SerializeField]
    [Header("敵に触れたとき音")]
    AudioClip _enemykSFX;

    [SerializeField]
    [Header("アイテムに触れたときの音")]
    AudioClip _itemSFX;

    AudioSource _audioSource;

    const string TITLE_SCENE_NAME = "TitleScene";
    const string GAME_SCENE_NAME = "GameScene";

    protected override void Awake()
    {
        base.Awake();

        if(TryGetComponent(out _audioSource))
        {
            Debug.Log("オーディオソースが参照できた");
        }

        FirstBGM();
    }

    void FirstBGM()
    {
        switch (SceneManager.GetActiveScene().name)
        {
            case TITLE_SCENE_NAME:
                _audioSource.clip = _titleBGM;
                break;

            case GAME_SCENE_NAME:
                _audioSource.clip = _gameBGM;
                break;
        }

        _audioSource.Play();
    }

    public void PlayBGM(BGMType type)
    {
        switch (type)
        {
            case BGMType.Title:
                _audioSource.clip = _titleBGM;
                break;

            case BGMType.Game:
                _audioSource.clip = _gameBGM;
                break;

            case BGMType.Result:
                _audioSource.clip = _resultBGM;
                break;
        }

        _audioSource.Play();
    }

    public void PlaySFX(SFXType type)
    {
        switch (type)
        {
            case SFXType.Death:
                _audioSource.PlayOneShot(_deathSFX);
                break;

            case SFXType.Enemy:
                _audioSource.PlayOneShot(_enemykSFX);
                break;

            case SFXType.Item:
                _audioSource.PlayOneShot(_itemSFX);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    [SerializeField]
    [Header("�^�C�g��")]
    AudioClip _titleBGM;

    [SerializeField]
    [Header("�Q�[��")]
    AudioClip _gameBGM;

    [SerializeField]
    [Header("���U���g")]
    AudioClip _resultBGM;

    [SerializeField]
    [Header("�v���C���[�����񂾂Ƃ��̉�")]
    AudioClip _deathSFX;

    [SerializeField]
    [Header("�G�ɐG�ꂽ�Ƃ���")]
    AudioClip _enemykSFX;

    [SerializeField]
    [Header("�A�C�e���ɐG�ꂽ�Ƃ��̉�")]
    AudioClip _itemSFX;

    AudioSource _audioSource;

    const string TITLE_SCENE_NAME = "TitleScene";
    const string GAME_SCENE_NAME = "GameScene";

    protected override void Awake()
    {
        base.Awake();

        if(TryGetComponent(out _audioSource))
        {
            Debug.Log("�I�[�f�B�I�\�[�X���Q�Ƃł���");
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

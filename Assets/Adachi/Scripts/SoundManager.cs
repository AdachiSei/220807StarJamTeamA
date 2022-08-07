using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    [Header("�^�C�g��")]
    AudioSource _titleAudioSource;

    [SerializeField]
    [Header("�Q�[��")]
    AudioClip _gameAudioSource;

    [SerializeField]
    [Header("���U���g")]
    AudioClip _resultAudioSource;

    [SerializeField]
    [Header("�N���b�N��")]
    AudioClip _clickSe;

    [SerializeField]
    [Header("���������̉�")]
    AudioClip _alignSe;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    [Header("タイトル")]
    AudioSource _titleAudioSource;

    [SerializeField]
    [Header("ゲーム")]
    AudioClip _gameAudioSource;

    [SerializeField]
    [Header("リザルト")]
    AudioClip _resultAudioSource;

    [SerializeField]
    [Header("クリック音")]
    AudioClip _clickSe;

    [SerializeField]
    [Header("揃った時の音")]
    AudioClip _alignSe;
}

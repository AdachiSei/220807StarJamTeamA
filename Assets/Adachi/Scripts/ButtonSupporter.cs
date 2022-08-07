using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSupporter : MonoBehaviour
{
    public void LoadScene(string name) => SceneLoader.Instance.LoadScene(name);
}

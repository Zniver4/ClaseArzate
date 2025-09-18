using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class LenguajeBehavior : MonoBehaviour
{
    public TMP_Dropdown droplenguajes;
    public List<string> LenguageOptions;

    void Start()
    {
        LenguageOptions = new List<string>();
        LenguageOptions.Add("Español");
        LenguageOptions.Add("English");

        droplenguajes.ClearOptions();
        droplenguajes.AddOptions(LenguageOptions);
    }
}

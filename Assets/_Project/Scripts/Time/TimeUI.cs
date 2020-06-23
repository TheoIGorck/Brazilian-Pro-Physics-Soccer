using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    [SerializeField] private Text _matchTimeText = default;
    
    public void UpdateTimeText(string minutes, string seconds)
    {
        _matchTimeText.text = minutes + ":" + seconds;
    }
}

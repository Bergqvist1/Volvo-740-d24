using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsUI : MonoBehaviour
{

    private SpelarePoints spelare;
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        spelare = GameObject.FindGameObjectWithTag("Player").GetComponent<SpelarePoints>();   
    }

    // Update is called once per frame
    void Update()
    {
        int p = spelare.Points;
        text.text = "MONGLIZZY: " + p;
    }
}

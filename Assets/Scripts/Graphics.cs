using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphics : MonoBehaviour
{
    // Start is called before the first frame update
    public void Low()
    {
        QualitySettings.SetQualityLevel(0);
    }

    public void Midium()
    {
        QualitySettings.SetQualityLevel(3);
    }
    public void High()
    {
        QualitySettings.SetQualityLevel(5);
    }
}

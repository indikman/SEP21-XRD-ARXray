using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyParts : MonoBehaviour
{
    public Image brainIcon;
    public Image heartIcon;

    public void OnBrainFound()
    {
        // Brain icon to light up!
        brainIcon.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        // heart icon to light up!
        heartIcon.color = new Color(1, 1, 1, 1);
    }
}

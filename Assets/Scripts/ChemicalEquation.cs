﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class ReactionComponent {
    public GameObject Element;
    public int Coefficient;
    public int id () { return Element.GetComponent<ChemicalElement>().id; }
}

[System.Serializable]

public class ChemicalEquation
{
    public ReactionComponent[] reactanti;
    public ReactionComponent[] produsi;
}
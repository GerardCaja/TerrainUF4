using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public bool _die = false;


    public void DiePlayer()
    {
        _die = true;
    }

}

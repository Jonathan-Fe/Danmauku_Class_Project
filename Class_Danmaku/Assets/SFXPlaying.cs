using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour
{
    public AudioSource Damage;
    public AudioSource Death;

    public void playDamage()
    {
        Damage.Play();
    }

    public void playDeath()
    {
        Death.Play();
    }


}

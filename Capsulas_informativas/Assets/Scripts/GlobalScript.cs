using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScript : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.PlayBackgroundEffect(AudioManager.BackgroundEffect.background);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            AudioManager.Instance.PlaySoundEffects(AudioManager.SoundEffect.Fire1);
        if (Input.GetButtonDown("Fire2"))
            AudioManager.Instance.PlaySoundEffects(AudioManager.SoundEffect.Fire2);
        if (Input.GetButtonDown("Fire3"))
            AudioManager.Instance.PlaySoundEffects(AudioManager.SoundEffect.Fire3);
        if (Input.GetButtonDown("Jump"))
            AudioManager.Instance.PlaySoundEffects(AudioManager.SoundEffect.Jump);
    }
}

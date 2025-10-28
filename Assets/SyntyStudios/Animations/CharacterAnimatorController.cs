using UnityEngine;

public class CharacterAnimatorController : MonoBehaviour
{
    public Animator[] animators;
    public GameObject musicPlayer;

    public void Idle()
    {
        foreach (var a in animators) a.SetTrigger("idle");
        musicPlayer.SetActive(false);
    }

    public void Dance()
    {
        foreach (var a in animators) a.SetTrigger("dance");
        musicPlayer.SetActive(true);
    }
}

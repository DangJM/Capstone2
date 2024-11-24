using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class AchievementNotificationController : MonoBehaviour
{
    [SerializeField] Text achievementTitleLabel;

    private Animator m_Animator;

    private void Awake()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void ShowNotification(Achievement achievement)
    {
        achievementTitleLabel.text = achievement.title;
        m_Animator.SetTrigger("Appear");
    }
}

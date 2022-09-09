using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using DG.Tweening;
using UnityEngine;

namespace rival
{
    
public class EnemyController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private CinemachinePath cinemachinePath;
    private List<Vector3> positions = new();
    private int _currentPositionIndex = -1;
    private bool _isDead = false;
    private static readonly int IsRun = Animator.StringToHash("IsRun");
    private static readonly int IsDeath = Animator.StringToHash("IsDead");

    void Start()
    {
        for (var i = 0; i < cinemachinePath.m_Waypoints.Length; i++)
        {
            positions.Add(cinemachinePath.m_Waypoints[i].position+cinemachinePath.transform.position);
        }
        NextPosition();
    }
    private void Respawn()
    {
        _isDead = false;
        Transform playerTransform;
        (playerTransform = transform).DOKill();
        playerTransform.position = positions[_currentPositionIndex-1];
        NextPosition(true);
    }

    private IEnumerator Dead()
    {
        _isDead = true;
        transform.DOKill();
        animator.SetTrigger(IsDeath);
        yield return new WaitForSeconds(5);
        Respawn();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("resistance"))
        {
            if (_isDead)
                return;
            StartCoroutine(Dead());
        }
        if(other.CompareTag("Finish"))
        {
           animator.SetTrigger("Finished");
          // StopCoroutine(Dead());
        }
    }

    private void NextPosition(bool withoutIncrease = false)
    {
        if(!withoutIncrease)
            _currentPositionIndex++;
        if(!_isDead)
            animator.SetTrigger(IsRun);
        if (_currentPositionIndex >= positions.Count)
        {
            Finished();
            return;
        }

        transform.DOKill();
        transform.DOMove(positions[_currentPositionIndex],
            Vector3.Distance(transform.position, positions[_currentPositionIndex])).SetEase(Ease.Linear).OnComplete(()=>NextPosition());
    }

    private void Finished()
    {
        transform.DOKill();
    }

    
    
}
}

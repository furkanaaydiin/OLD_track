using UnityEngine;
using DG.Tweening;

public class Rotator2_Contollers : MonoBehaviour
{
    public GameObject rotator2;
    public float duration;
    public bool direction;

    private void Awake()
    {
        var moveRot = direction == false ? -360 : 360;
            rotator2.transform.DOLocalRotate(Vector3.up * (rotator2.transform.localEulerAngles.y + moveRot),duration,RotateMode.FastBeyond360)
            .SetLoops(-1,LoopType.Restart)
            .SetEase(Ease.Linear);
    }
}

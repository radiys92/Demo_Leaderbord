using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GoToggle : Toggle
{
    [SerializeField]
    private GameObject _TargetGo;

    protected override void OnValidate()
    {
        base.OnValidate();
        UpdateState();
    }

    protected override void Start()
    {
        base.Start();
        if (_TargetGo != null)
            onValueChanged.AddListener(_TargetGo.SetActive);
    }

    private void UpdateState()
    {
        if (_TargetGo != null)
            _TargetGo.SetActive(isOn);
    }
}
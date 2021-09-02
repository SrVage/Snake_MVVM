using System;
using UnityEngine;
using ViewModel;

namespace View
{
    public class AppleView:MonoBehaviour
    {
        private AppleVM _appleVm;
        public event Action EatApple;

        public void Initialize(AppleVM appleVm)
        {
            _appleVm = appleVm;
            _appleVm.ChangeApplePosition += ChangePosition;
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (!other.GetComponent<HeadView>()) return;
            EatApple?.Invoke();
            _appleVm.AppleEat();
        }

        private void ChangePosition(Vector3 position)
        {
            transform.position = position;
        }
    }
}